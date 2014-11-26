#pragma strict

function OnTriggerEnter(collision:Collider)
{
    if (collision.gameObject.tag == "kill")
    {
       this.gameObject.renderer.enabled =false; 
       Destroy(this.gameObject);    
    }




}