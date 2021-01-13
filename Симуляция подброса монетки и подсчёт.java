import java.util.ArrayList;
import java.util.Random;
import java.util.Scanner;

public class Main {

    private ArrayList<Integer> history = new ArrayList<Integer>();
    private static int reshka = 0;
    private static int orel = 0;

    public static void main(String[] args)
    {
        Scanner scan = new Scanner(System.in);
        System.out.println("Введите количество раз для симуляций подбрасываний монетки");
        Random rand = new Random();
        int count =  scan.nextInt();
        for (int i = 0; i < count ; i++) {
            if(rand.nextBoolean()){
                reshka++;
            }else{
                orel++;
            }
        }
        System.out.println("Решка выпала: " + reshka + "/" + count  + " Орёл выпал: " + orel + "/" + count );
    }

}
