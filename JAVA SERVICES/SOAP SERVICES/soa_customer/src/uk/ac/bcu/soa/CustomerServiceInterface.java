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
public interface CustomerServiceInterface {
    public List<Customer> getAll();
    public Response addCustomer(Customer customer);
    public Response updateCustomer(Customer customer);
    public Response deleteCustomer(String customerId);
    public Customer getCustomer(String customerId);
    public Customer getCustomerName(String customerName);
}