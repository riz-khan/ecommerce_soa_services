package uk.ac.bcu.soa.auth;

import java.security.NoSuchAlgorithmException;
import java.util.List;
import javax.ws.rs.Consumes;
import javax.ws.rs.DELETE;
import javax.ws.rs.GET;
import javax.ws.rs.POST;
import javax.ws.rs.PUT;
import javax.ws.rs.Path;
import javax.ws.rs.PathParam;
import javax.ws.rs.Produces;
import javax.xml.bind.annotation.XmlRootElement;
import uk.ac.bcu.soa.file.SystemFile;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author CMP7174User
 */
@Path("/userservice/")
@Produces("text/xml")
@Consumes("text/xml")
@XmlRootElement(name="user")
public class UserService {    
    
    public UserService() {
        Server.users.add(new User("1","adnanraza","adnan"));
        Server.users.add(new User("2","rizwankhan","rizwan"));
        
        SystemFile.appendFile(Server.SYSTEM_FILE, Server.toCSV());
    }
    
    @GET
    @Path("/login/{userName}/{password}")
    public User getLogin(@PathParam("userName") String userName, @PathParam("password") String password) throws NoSuchAlgorithmException{
        for(User u: Server.users){
            if(u.getUserName().equals(userName) &&
                    u.getPass().equals(password)){
                    u.generateToken();
                    Server.loggedIn.add(u);
                    return u;
            }
        }
        return null;
    }
    
    @GET
    @Path("/logout/{id}")
    public Boolean getLogout(@PathParam("id") String id){
        for(User u: Server.users){
            if(u.getUuid().equals(id)){
                Server.loggedIn.remove(id);
                return true;
            }
        }
        return false;
    }
    
    @GET
    @Path("/authenticate/{token}")
    public Boolean authenticate(@PathParam("id") String token){
        for(User u: Server.loggedIn){
            if(u.getToken().equals(token)){
                return true;
            }
        }
        return false;
    }
    
    @GET
    @Path("/getuser/{id}")
    public User getUser(@PathParam("id") String id){
        for(User u: Server.users){
            if(u.getUuid().equals(id)){
                return u;
            }
        }
        return null;
    }
    
    @GET
    @Path("/getusers")
    public List<User> getUsers(){
        return Server.users;
    }
    
    @PUT
    @Path("/updateuser")
    public boolean updateUser(User user){
        
        try{
            for(User u:Server.users){
                if(u.getUuid().equals(user.getUuid())){
                    u.setUserName(user.getUserName());
                    u.setPass(user.getPass());

                    SystemFile.appendFile(Server.SYSTEM_FILE, Server.toCSV());
                }
            }
        }catch(Exception ex){
            ex.printStackTrace();
            return false;
        }
        
        return true;
    }
    
    @POST
    @Path("/register/")
    public boolean addUser(User user){
        System.out.println("User = "+user.getUserName());
        user.setUuid((Server.users.size()+1)+"");
        Server.users.add(user);
        SystemFile.appendFile(Server.SYSTEM_FILE, Server.toCSV());
        return true;
    }
    
    @DELETE
    @Path("/delete/{id}")
    public boolean deleteUser(@PathParam("id") String id){
        for(User u: Server.users){
            if(u.getUuid().equals(id)){
                Server.users.remove(u);
                SystemFile.appendFile(Server.SYSTEM_FILE, Server.toCSV());
                return true;
            }
        }
        return false;
    }
}
