package uk.ac.bcu.soa;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */


/**
 *
 * @author CMP7174User
 */
public class Response {
    private boolean success;
    private String message;

    Response(boolean success,String message){
        this.success = success;
        this.message = message;
    }

    Response() {
    }

    
    //GETTER SETTER
    public String getMessage() {
        return message;
    }

    public void setMessage(String message) {
        this.message = message;
    }

    public boolean isSuccess() {
        return success;
    }

    public void setSuccess(boolean success) {
        this.success = success;
    }
}
