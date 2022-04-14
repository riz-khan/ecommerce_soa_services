/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package uk.ac.bcu.soa.auth;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;
import javax.ws.rs.WebApplicationException;
import javax.ws.rs.core.MediaType;
import javax.ws.rs.core.Response;
import javax.ws.rs.core.Response.ResponseBuilder;
import javax.ws.rs.core.Response.Status;
import org.apache.cxf.jaxrs.JAXRSServerFactoryBean;
import org.apache.cxf.jaxrs.lifecycle.SingletonResourceProvider;
import uk.ac.bcu.soa.file.SystemFile;

/**
 *
 * @author CMP7174User
 */
public class Server {
    
    public static final String SYSTEM_FILE = "C:\\Users\\CMP7174User\\Documents\\Auth.txt";
    public static List<User> users = new ArrayList<User>(0);
    public static List<User> loggedIn = new ArrayList<>(0);

    
    protected Server() throws Exception {
        JAXRSServerFactoryBean sf = new JAXRSServerFactoryBean();
        sf.setResourceClasses(UserService.class);
        sf.setResourceProvider(UserService.class,
                new SingletonResourceProvider(new UserService()));
        sf.setAddress("http://localhost:8080");
        sf.create();
        
        initiateFile(SYSTEM_FILE);
    }
    
    public WebApplicationException createStatusException(String statusMessage) {
        ResponseBuilder rb = Response.noContent();
        rb = rb.type(MediaType.APPLICATION_JSON);
        rb = rb.status(Status.BAD_REQUEST);
        rb = rb.entity(statusMessage);
        return new WebApplicationException(rb.build());
    }
    
    public void initiateFile(String systemFile){
        if(SystemFile.checkExsist(systemFile)){
            System.out.println("System file initiated");
            List<String> cust = SystemFile.readFile(systemFile);
            if(cust.size()>0) users.clear();
            for(String customer:cust){
                String[] csv = customer.split(",");
                
                users.add(new User(csv[0],csv[1],csv[2]));
            }
        }else{
            if(SystemFile.createFile(systemFile)){
                List<String> customerData = new ArrayList<>();
                for(User user: users){
                    customerData.add(user.getCSV());
                }
                System.out.println("WRITE ="+SystemFile.writeData(systemFile, customerData));
            }else{
                System.err.println("Unable to create File");
            }
        }
    }
    
    public static List<String> toCSV(){
            List<String> cData= new ArrayList<>();
            for(User user: users){
                cData.add(user.getCSV());
            }
        return cData;
    }
    
    public static void main(String args[]) throws Exception {
        new Server();
        System.out.println("Auth service has started on 8080 ");
        System.out.println("Press any key to exit");
        (new Scanner(System.in)).nextLine();
        System.exit(0);
    }
}
