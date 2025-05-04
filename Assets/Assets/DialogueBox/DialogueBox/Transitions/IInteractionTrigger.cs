/// <summary>
/// Interface used by all dialogue interaction trigger scripts
/// so the InteractionManager can call them generically.
/// </summary>
public interface IInteractionTrigger
{
    void TriggerDialogue();
    string GetConcept();    // new
    int GetAttribute();  // new
}
