public class Cat extends Animal {
    private String color;

    public Cat(String name, String sound, String color) {
        super(name, sound);
        this.color = color;
    }

    @Override
    public String toString() {
        return "Cat [Name: " + name + ", Sound: " + sound + ", Color: " + color + "]";
    }
}