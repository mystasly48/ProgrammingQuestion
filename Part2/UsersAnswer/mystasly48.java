import java.util.*;
public class Part2 {
  public static void main(String[] args) throws Exception {
    Scanner sc = new Scanner(System.in);
    String line = sc.nextLine();
    int max = Integer.parseInt(line);
    Random rand = new Random();
    int result = rand.nextInt(max + 1);
    System.out.println(result);
  }
}
