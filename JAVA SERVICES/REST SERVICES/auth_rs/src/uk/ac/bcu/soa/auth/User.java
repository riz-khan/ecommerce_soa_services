package uk.ac.bcu.soa.auth;


import java.security.MessageDigest;
import java.security.NoSuchAlgorithmException;
import javax.xml.bind.DatatypeConverter;
import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlRootElement;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author CMP7174User
 */
@XmlRootElement(name = "User", namespace="")
@XmlAccessorType(XmlAccessType.FIELD)
public class User {    
    private String uuid;
    private String userName;
    private String pass;
    private String isValidToken;
    private String token;
    
    public User(String uuid,String userName,String pass){
        this.uuid= uuid;
        this.userName = userName;
        this.pass = pass;
    }
    
    public void generateToken() throws NoSuchAlgorithmException{
        String hash = this.userName;
        String password = this.pass;

        MessageDigest md = MessageDigest.getInstance("MD5");
        md.update(password.getBytes());
        byte[] digest = md.digest();
        
        token = DatatypeConverter.printHexBinary(digest).toUpperCase();
    }
    
    public String getCSV(){
        return this.uuid+","+
                    this.userName+","+
                    this.pass;
    }
    
    public String toString(){
        return uuid+", "+userName;
    }

    public User() {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }
    //GETTER SETTER
    public String getUserName() {
        return userName;
    }

    public void setUserName(String userName) {
        this.userName = userName;
    }

    public String getPass() {
        return pass;
    }

    public void setPass(String pass) {
        this.pass = pass;
    }

    public String getIsValidToken() {
        return isValidToken;
    }

    public void setIsValidToken(String isValidToken) {
        this.isValidToken = isValidToken;
    }
    
    public String getUuid() {
        return uuid;
    }

    public void setUuid(String uuid) {
        this.uuid = uuid;
    }
    
    public String getToken() {
        return token;
    }

    public void setToken(String token) {
        this.token = token;
    }

}
