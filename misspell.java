import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner getInput = new Scanner(System.in);

        int numWords  = Integer.parseInt(getInput.nextLine());

        String[] words = new String[numWords];

        for (int i = 0; i < numWords; i++) {
			words[i] = getInput.nextLine();
		}

        int currentWordNum = 1;


		for (String element : words) {

			int spaceAt = element.indexOf(" ");

			String myWord = element.substring(spaceAt + 1);
			
			int deleteAt;

			switch (spaceAt) {
				case 1:
					deleteAt = Integer.parseInt(String.valueOf(element.charAt(0)));
					break;
				default:
					deleteAt = Integer.parseInt(element.substring(0, 2));
					break;
			}
			
			System.out.print(currentWordNum + " ");
			currentWordNum++;

			for (int j = 1; j <= myWord.length(); j++) {
				if (j != deleteAt) {
					System.out.print(myWord.charAt(j-1));
				}
			}

			System.out.println();

		}

    }
}