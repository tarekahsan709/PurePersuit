import java.util.ArrayList;
public class PhoneBook extends User {
    ArrayList<String> phoneNumber=new ArrayList<String>();

    public PhoneBook(String name, String address,ArrayList number) {
        super(name, address);
        phoneNumber.addAll(number);
    }

    public PhoneBook() {
    }
}
