package uk.ac.bcu.soa;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */


import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;
import javax.xml.ws.Endpoint;
import uk.ac.bcu.soa.file.SystemFile;

/**
 *
 * @author CMP7174User
 */
public class Server {
    
    private static List<Product> productList = new ArrayList<Product>(0);
    public static final String SYSTEM_FILE = "C:\\Users\\CMP7174User\\Documents\\Product.txt";
    
    protected Server() throws Exception {
        ProductServiceImpl impl = new ProductServiceImpl();
        System.out.println("PRODUCT SERVICE HAS STARTED on 8081");
        String add = "http://localhost:8081/product";

        Endpoint.publish(add, impl);

        //Adding static product list;
        productList.add(new Product("PRD7894","Product1",3.99,100,"123123123123",true));
        productList.add(new Product("PRD5587","Product2",4.99,100,"456456456456",true));
        productList.add(new Product("PRD5536","Product3",5.99,100,"789789897987",true));
        productList.add(new Product("PRD3365","Product4",6.99,100,"741741741741",true));
        productList.add(new Product("PRD4425","Product5",7.99,100,"852852852852",true));
        productList.add(new Product("PRD2335","Product6",8.99,100,"963969639696",true));
        productList.add(new Product("PRD8956","Product7",9.99,100,"951951951951",true));

        initiateFile(SYSTEM_FILE);     
    }
    
    public void initiateFile(String systemFile){
        if(SystemFile.checkExsist(systemFile)){
            System.out.println("System file initiated");
            List<String> cust = SystemFile.readFile(systemFile);
            if(cust.size()>0) productList.clear();
            for(String customer:cust){
                String[] csv = customer.split(",");
                productList.add(new Product(csv[0],csv[1],Double.parseDouble(csv[2]),Integer.parseInt(csv[3]),csv[4],Boolean.parseBoolean(csv[5])));
            }
        }else{
            if(SystemFile.createFile(systemFile)){
                System.out.println("WRITE ="+SystemFile.writeData(systemFile, toCSV()));
            }else{
                System.err.println("Unable to create File");
            }
        }
    }
    
    public static List<String> toCSV(){
            List<String> prodData= new ArrayList<>();
            for(Product prod: productList){
                prodData.add(prod.getCSV());
            }
        return prodData;
    }
    
    public static void main(String[]args) throws Exception{
        new Server();
        
        System.out.println("Press any key to exit");
        (new Scanner(System.in)).nextLine();
        System.exit(0);
    }
    
    public static List<Product> getProductList() {
        return productList;
    }
    public static void setProductList(List<Product> userList) {
        Server.productList = userList;
    }
}
