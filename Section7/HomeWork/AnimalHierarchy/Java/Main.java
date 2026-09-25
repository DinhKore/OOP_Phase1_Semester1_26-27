public class Main {
    public static void main(String[] args) {
        Dog dog = new Dog("Buddy", "Woof", "Golden Retriever");
        Cat cat = new Cat("Whiskers", "Meow", "Black");
        Bird bird = new Bird("Tweety", "Chirp", true);

        System.out.println(dog.toString());
        System.out.println(cat.toString());
        System.out.println(bird.toString());
    }
}