import java.util.Scanner;

public class Main {

    private static int mounthCount;
    private static double procents;
    private static int costGlobal;
    private static double firstPay;

    public static void main(String[] args)
    {
        Scanner scan = new Scanner(System.in);
        System.out.println("Введите срок в месяцах");
        mounthCount = scan.nextInt();
        System.out.println("Введите процентную ставку годовых");
        procents = scan.nextDouble();
        System.out.println("Введите общую стоимость");
        costGlobal = scan.nextInt();
        System.out.println("Введите первоночальный взнос");
        firstPay = scan.nextDouble();
        costGlobal -= firstPay;
        double everyMounthBet = procents / 12 / 100;
        double totalBet = Math.pow(1+everyMounthBet, mounthCount);
        double overPayment = getEveryMounthPay(everyMounthBet,totalBet,costGlobal) * mounthCount - costGlobal;
        System.out.println("Сумма ежемесечного платежа = " + getEveryMounthPay(everyMounthBet,totalBet,costGlobal));
        System.out.println("Переплата = " + overPayment);
    }

    private static double getEveryMounthPay(double everyMounthBet,double totalBet,int costGlobal){
        return (costGlobal * everyMounthBet * totalBet) / (totalBet -1);
    }
}
