class Person {
    String name;

    public Person(String name) {
        this.name = name;
    }

    public void introduce() {
        System.out.println("Hello, my name is " + name + ".");
    }
}

public class Main {
    public static void main(String[] args) {
        // Creates one object and calls introduce()
        Person myPerson = new Person("Dinh");
        myPerson.introduce();
    }
}