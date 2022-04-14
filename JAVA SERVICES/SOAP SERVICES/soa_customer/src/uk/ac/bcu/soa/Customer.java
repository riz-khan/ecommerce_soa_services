/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package uk.ac.bcu.soa;

/**
 *
 * @author CMP7174User
 */
public class Customer {
    
    private String customerID;
    private String name;
    private String email;
    private String phone;
    private String cardNumber;
    private String cardName;
    private String cardCvv;
    private String cardExpiry;

    
    public Customer(){
        
    }
    public Customer(String customerId,String name,String email,String phone,
                String cardNumber,String cardName,String cardExpiry,String cardCvv){
        this.customerID = customerId;
        this.name = name;
        this.email = email;
        this.phone = phone;
        this.cardNumber = cardNumber;
        this.cardName = cardNumber;
        this.cardCvv = cardCvv;
        this.cardExpiry = cardExpiry;
    }
    
    public String getCSV(){
       String toReturn = this.customerID+","+
                            this.name+","+
                            this.email+","+
                            this.phone+","+
                            this.cardNumber+","+
                            this.cardName+","+
                            this.cardCvv+","+
                            this.cardExpiry;
       return toReturn;
    }

    public String getCustomerID() {
        return customerID;
    }

    public void setCustomerID(String customerID) {
        this.customerID = customerID;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getEmail() {
        return email;
    }

    public void setEmail(String email) {
        this.email = email;
    }

    public String getPhone() {
        return phone;
    }

    public void setPhone(String phone) {
        this.phone = phone;
    }

    public String getCardNumber() {
        return cardNumber;
    }

    public void setCardNumber(String cardNumber) {
        this.cardNumber = cardNumber;
    }

    public String getCardName() {
        return cardName;
    }

    public void setCardName(String cardName) {
        this.cardName = cardName;
    }

    public String getCardCvv() {
        return cardCvv;
    }

    public void setCardCvv(String cardCvv) {
        this.cardCvv = cardCvv;
    }

    public String getCardExpiry() {
        return cardExpiry;
    }

    public void setCardExpiry(String cardExpiry) {
        this.cardExpiry = cardExpiry;
    }
}
