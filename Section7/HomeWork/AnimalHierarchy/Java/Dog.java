public class Dog extends Animal {
    private String breed;

    public Dog(String name, String sound, String breed) {
        super(name, sound);
        this.breed = breed;
    }

    @Override
    public String toString() {
        return "Dog [Name: " + name + ", Sound: " + sound + ", Breed: " + breed + "]";
    }
}