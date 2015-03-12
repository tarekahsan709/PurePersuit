import java.util.*;

public class Main {
    public static void main(String[] args){
        HashMap<String,User> userInfo=new HashMap<String, User>();
        ArrayList<String> number=new ArrayList<String>();
        String tempName;
        String tempNumber;
        String tempAddress;
        String dummy;
        String choice;
        String next;
        String reges= "[0-9]+";
        Main main=new Main();
        Choice c;
        boolean bool;

        Scanner sc=new Scanner(System.in);
        for (;;){
            System.out.println("Insert Contact");
            System.out.println("Find Contact");
            System.out.println("Show All Contact Name");
            choice=sc.nextLine();

            if (choice.toLowerCase().contentEquals("insert")){
                 c=Choice.Insert;
            }
            else if(choice.toLowerCase().contentEquals("find")) {
                 c=Choice.Find;
            }
            else if(choice.toLowerCase().contentEquals("show")){
                c=Choice.Show;
            }
            else {
                System.out.println("Enter choice with correct spelling");
                continue;
            }

            switch (c){
                case Insert:
                    for (;;){
                        System.out.println("Enter the user Name");
                        tempName=sc.nextLine();
                        if(tempName.matches(reges)){//some bug goes here
                            continue;
                        }
                        else {
                            break;
                        }
                    }

                    for(;;){

                        System.out.println("Enter the user Number");//some bug goes here
                        tempNumber=sc.nextLine();
                        if(tempNumber.matches(reges)){
                            number.add(tempNumber);
                        }
                        else {
                            continue;
                        }


                        System.out.println("Ok or Next");
                        next=sc.nextLine();
                        if(next.toLowerCase().contentEquals("ok")){
                            break;
                        }
                        else {
                            continue;
                        }
                    }


                    System.out.println("Enter the user Address");
                    tempAddress=sc.nextLine();

                    User user;
                    PhoneBook ph;
                    user=new PhoneBook(tempName,tempAddress,number);
                    userInfo.put(tempName,user);

                    break;
                case Find:
                    System.out.println("Enter the user Name");
                    tempName=sc.nextLine();
                    if(!userInfo.isEmpty()){

                        User map=userInfo.get(tempName);
                        if(map!=null){
                            System.out.println(map.getuName());
                            System.out.println("user address :");
                            System.out.println(map.getuAddress());
                            ph=(PhoneBook)map;
                            int lenght;
                            lenght=ph.phoneNumber.size();
                            System.out.println("Phone numbers are:");
                            for(int i=0;i<lenght;i++){
                                System.out.println(ph.phoneNumber.get(i));
                            }

                        }


                    }
                    else{
                        System.out.println("No Contact is in the list");
                    }

                    break;
                case Show:
                    Set<String> keys=userInfo.keySet();
                    if(!userInfo.isEmpty()){
                        for (String key : keys){
                            System.out.println(key);
                        }
                    }
                    else {
                        System.out.println("No Contact List");
                    }
                default:break;
            }
        }
       









    }
}
