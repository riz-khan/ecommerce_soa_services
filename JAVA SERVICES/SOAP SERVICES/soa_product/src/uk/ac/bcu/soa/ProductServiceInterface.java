package uk.ac.bcu.soa;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */


import java.util.List;
import javax.jws.WebService;

/**
 *
 * @author CMP7174User
 */
@WebService
public interface ProductServiceInterface {
    public List<Product> getAll();
    public Product get(String id);
    public Product getName(String id);
    public Integer checkStock(String id);
    public Integer checkStockByName(String id);
    public Response add(Product prod);
    public Response update(Product prod);
    public Response delete(String prodId);
    public Response stockIn(String id,Integer quantity);
    public Response stockOut(String id,Integer quantity);
}
