public class Bird extends Animal {
    private boolean canFly;

    public Bird(String name, String sound, boolean canFly) {
        super(name, sound);
        this.canFly = canFly;
    }

    @Override
    public String toString() {
        return "Bird [Name: " + name + ", Sound: " + sound + ", CanFly: " + canFly + "]";
    }
}