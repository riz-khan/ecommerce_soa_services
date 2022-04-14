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
    
    private static List<Customer> customerList = new ArrayList<Customer>(0);
    public static final String SYSTEM_FILE = "C:\\Users\\CMP7174User\\Documents\\Customer.txt";
    
    protected Server() throws Exception {
        CustomerService impl = new CustomerService();
        System.out.println("CUSTOMER SERVICE HAS STARTED on 8084");
        String add = "http://localhost:8084/customer";
        
        customerList.add(new Customer("CUST1213","Adnan","adnan@mail.com","07944444444",
                        "1234-7412-7896-8521","Adnan Raza","12/24","001"));
        
        customerList.add(new Customer("CUST1224","Rizwan","rizwan@mail.com","07944444445",
                        "1234-7532-7548-8521","Rizwan Khan","10/24","004"));
        
        customerList.add(new Customer("CUST1245","Bilal","bilal@mail.com","07944444444",
                        "7417-7412-7896-8521","Bilal Ahmed","12/23","005"));
        
        customerList.add(new Customer("CUST1526","MSalman","msalman@mail.com","07944444444",
                        "7417-7412-7896-8521","Hafiz Muhammad Salman","12/24","006"));
        
        customerList.add(new Customer("CUST1287","Nishit","nishit@mail.com","07944444444",
                        "8041-7412-7896-8521","Nishit Chitaliya","07/25","007"));
        
        
        
        
        initiateFile(SYSTEM_FILE);
                
        Endpoint.publish(add, impl);        
    }
    
    public void initiateFile(String systemFile){
        if(SystemFile.checkExsist(systemFile)){
            System.out.println("System file initiated");
            List<String> cust = SystemFile.readFile(systemFile);
            if(cust.size()>0) customerList.clear();
            for(String customer:cust){
                String[] csv = customer.split(",");
                
                customerList.add(new Customer(csv[0],csv[1],csv[2],csv[3],csv[4],csv[5],csv[6],csv[7]));
            }
        }else{
            if(SystemFile.createFile(systemFile)){
                List<String> customerData = new ArrayList<>();
                for(Customer customer: customerList){
                    customerData.add(customer.getCSV());
                }
                System.out.println("WRITE ="+SystemFile.writeData(systemFile, customerData));
            }else{
                System.err.println("Unable to create File");
            }
        }
    }
    
    public static List<String> toCSV(){
            List<String> cData= new ArrayList<>();
            for(Customer cust: customerList){
                cData.add(cust.getCSV());
            }
        return cData;
    }
    
    public static void main(String[]args) throws Exception{
        new Server();
        
        System.out.println("Press any key to exit");
        (new Scanner(System.in)).nextLine();
        System.exit(0);
    }
    
    //GETTER SETTER
    public static List<Customer> getCustomerList() {
        return customerList;
    }

    public static void setCustomerList(List<Customer> customerList) {
        Server.customerList = customerList;
    }
}
