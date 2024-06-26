public interface IEvent { }

public struct TestEvent : IEvent { }

public struct PlayerEvent : IEvent {
    public int health;
    public int mana;
}

public struct InteractionEvent : IEvent {
    public bool canTalk;
    public bool canInspect;
    public bool canPick;
}