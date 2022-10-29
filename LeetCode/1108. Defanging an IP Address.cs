public class Solution {
    public string DefangIPaddr(string address) {
        /*Given a valid (IPv4) IP address, return a defanged version of that IP address.
A defanged IP address replaces every period "." with "[.]".*/
      return address.Replace(".", "[.]");
      
    }
}