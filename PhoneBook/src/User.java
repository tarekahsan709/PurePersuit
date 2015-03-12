/**
 * Created by tarak_000 on 1/19/2015.
 */
public class User {
    private String uName;
    private String uAddress;

    public void setuName(String uName) {
        this.uName = uName;
    }

    public void setuAddress(String uAddress) {
        this.uAddress = uAddress;
    }

    public String getuAddress() {
        return uAddress;
    }

    public String getuName() {
        return uName;
    }

    public User(String name,String address) {
        this.uName=name;
        this.uAddress=address;
    }

    public User() {
    }


}
