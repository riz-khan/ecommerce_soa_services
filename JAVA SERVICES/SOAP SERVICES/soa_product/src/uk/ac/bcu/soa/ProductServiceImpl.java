package uk.ac.bcu.soa;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */


import java.util.List;
import javax.jws.WebService;
import uk.ac.bcu.soa.file.SystemFile;

/**
 *
 * @author CMP7174User
 */
@WebService(endpointInterface="uk.ac.bcu.soa.ProductServiceInterface", serviceName="ProductService")
public class ProductServiceImpl implements ProductServiceInterface  {

    
    @Override
    public List<Product> getAll() {
        return Server.getProductList();
    }

    @Override
    public Product get(String id) {
        for(Product p:Server.getProductList()){
            if(p.getId().equals(id)){
                return p;
            }
        }
        return null;
    }

    @Override
    public Response add(Product prod) {
        Response res = new Response();
        
        prod.setId(generateId());
        System.out.println(prod.getId());
        
        Server.getProductList().add(prod);
        res.setSuccess(true);
        res.setMessage("Product saved successfully");
        SystemFile.appendFile(Server.SYSTEM_FILE, Server.toCSV());
        return new Response(true,"Product saved successfully!");
    }

    @Override
    public Response update(Product prod) {
        Response res = new Response();
        for(Product p:Server.getProductList()){
            if(p.getId().equals(prod.getId())){
                p.setActive(prod.isActive());
                p.setBarCode(prod.getBarCode());
                p.setName(prod.getName());
                p.setPrice(prod.getPrice());
                p.setQuantity(prod.getQuantity());
                res.setSuccess(true);
                res.setMessage("Product updated Successfully!");
                return res;
            }
        }
        res.setSuccess(false);
        res.setMessage("Cannot find product!");
        SystemFile.appendFile(Server.SYSTEM_FILE, Server.toCSV());
        return new Response(false,"Cannot find product!");
    }

    @Override
    public Response delete(String prodId) {
        for(Product p:Server.getProductList()){
            if(p.getId().equals(prodId)){
                Server.getProductList().remove(p);
                Response res = new Response(true,"Product removed successfully!");
                return res;
            }
        }
        Response res = new Response(false,"Cannot find product!");
        SystemFile.appendFile(Server.SYSTEM_FILE, Server.toCSV());
        return res;
    }

    @Override
    public Response stockIn(String id, Integer quantity) {
        for(Product p:Server.getProductList()){
            if(p.getId().equals(id)){
                int qut = p.getQuantity() + quantity;
                p.setQuantity(qut);
                Response res = new Response(true,"Product stock added successfully!");
                return res;
            }
        }
        Response res = new Response(false,"Cannot find product!");
        SystemFile.appendFile(Server.SYSTEM_FILE, Server.toCSV());
        return res;
    }

    @Override
    public Response stockOut(String id, Integer quantity) {
        for(Product p:Server.getProductList()){
            if(p.getId().equals(id)){
                int qut = p.getQuantity() - quantity;
                p.setQuantity(qut);
                Response res = new Response(true,"Product stock removed successfully!");
                return res;
            }
        }
        Response res = new Response(false,"Cannot find product!");
        SystemFile.appendFile(Server.SYSTEM_FILE, Server.toCSV());
        return res;
    }

    private String generateId() {
        String uid = ("PRD"+((Math.random() * ( 9999 - 1000)) + 1000 )+"").split("\\.")[0];
        if(get(uid)!=null){
            generateId();
        }
        return uid;
    }

    @Override
    public Product getName(String name) {
        for(Product p:Server.getProductList()){
            if(p.getName().equals(name)){
                return p;
            }
        }
        return null;
    }

    @Override
    public Integer checkStock(String id) {
        for(Product p:Server.getProductList()){
            if(p.getId().equals(id)){
                return p.getQuantity();
            }
        }
        return null;
    }

    @Override
    public Integer checkStockByName(String name) {
        for(Product p:Server.getProductList()){
            if(p.getName().equals(name)){
                return p.getQuantity();
            }
        }
        return null;
    }

}
