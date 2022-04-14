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
@WebService(endpointInterface="uk.ac.bcu.soa.CustomerServiceInterface", serviceName="CustomerService")
public class CustomerService implements CustomerServiceInterface  {
    
    @Override
    public List<Customer> getAll() {
        return Server.getCustomerList();
    }
    
    
    @Override
    public Response addCustomer(Customer customer){
        Response res = new Response();
        
        res = checkEmpty(customer);
        if(!res.isSuccess()){
            return res;
        }
        customer.setCustomerID(generateId());
        
        Server.getCustomerList().add(customer);
        res.setSuccess(true);
        res.setMessage("Customer added successfully");
        SystemFile.appendFile(Server.SYSTEM_FILE, Server.toCSV());
        return res;
    }
    
    private String generateId() {
        String uid = ("CUS"+((Math.random() * ( 9999 - 1000)) + 1000 )+"").split("\\.")[0];
        if(getCustomer(uid)!=null){
            generateId();
        }
        return uid;
    }
    
    
    @Override
    public Response updateCustomer(Customer customer){
        Response res = new Response();
        
        res = checkEmpty(customer);
        System.out.println("RES = "+res.isSuccess());
        System.out.println("RES = "+res.getMessage());
        if(!res.isSuccess()){
            return res;
        }
        
        for(Customer cust:Server.getCustomerList()){
            if(cust.getCustomerID().equals(customer.getCustomerID())){
                cust.setName(customer.getName());
                cust.setCardCvv(customer.getCardCvv());
                cust.setCardExpiry(customer.getCardExpiry());
                cust.setCardName(customer.getCardName());
                cust.setEmail(customer.getEmail());
                cust.setPhone(customer.getPhone());
                
                res.setSuccess(true);
                res.setMessage("Customer updated successfully");
                
                SystemFile.appendFile(Server.SYSTEM_FILE, Server.toCSV());
            }
        }
        
        if(!res.isSuccess()){
            res.setSuccess(false);
            res.setMessage("Unable to find customer with id "+customer.getCustomerID());
                
            return res;
        }
        return res;
    }
    
    @Override
    public Response deleteCustomer(String customerId){
        Response res = new Response();
        
        for(Customer cust:Server.getCustomerList()){
            if(cust.getCustomerID().equals(customerId)){
                Server.getCustomerList().remove(cust);
                res.setSuccess(true);
                res.setMessage("Customer deleted successfully");
                
                SystemFile.appendFile(Server.SYSTEM_FILE, Server.toCSV());
                
                return res;
            }
        }
        res.setSuccess(false);
        res.setMessage("Unable to find customer with id "+customerId);

        return res;
    }
    
    @Override
    public Customer getCustomer(String customerId){
        for(Customer cust:Server.getCustomerList()){
            if(cust.getCustomerID().equals(customerId)){
                return cust;
            }
        }
        return null;
    }
    
    
    private Response checkEmpty(Customer customer) {
        Response res = new Response();
        if(customer == null){
            res.setSuccess(false);
            res.setMessage("Empty values not allowed");
            return res;
        }
        if(customer.getName().isEmpty() ||
                customer.getCardCvv().isEmpty() ||
                customer.getCardExpiry().isEmpty() ||
                customer.getCardName().isEmpty() ||
                customer.getEmail().isEmpty() ||
                customer.getCardNumber().isEmpty() ||
                customer.getPhone().isEmpty() ){
            
            res.setSuccess(false);
            res.setMessage("Empty values not allowed");
        }else{
            res.setSuccess(true); 
        }
        return res;
    }

    @Override
    public Customer getCustomerName(String customerName) {
        for(Customer cust:Server.getCustomerList()){
            if(cust.getName().equals(customerName)){
                return cust;
            }
        }
        return null;
    }
}