using UnityEngine;

public class ProjectileLauncher : MonoBehaviour
{
   public Transform launchPoint;
   public GameObject pontoLancamento;
   public GameObject projectile;
   public float launchSpeed = 10f;
   public float launchAngle;
   public float forca = 100f;

   public void receberDado(int n){
    forca*=n;
   }

   void Update(){
    if(Input.GetMouseButtonDown(0)){
        var _projectile = Instantiate(projectile, pontoLancamento.transform.position, pontoLancamento.transform.rotation);
        Rigidbody rb = _projectile.GetComponent<Rigidbody>();

        // Converte o ângulo de lançamento para radianos
        float radianAngle = launchAngle * Mathf.Deg2Rad;

        // Calcula as componentes x e y da direção de lançamento
        Vector2 launchDirection = new Vector2(
            Mathf.Cos(radianAngle) * launchPoint.forward.x,
            Mathf.Sin(radianAngle)
        );

        // Aplica a força na direção calculada
        rb.AddForce(launchDirection * forca, ForceMode.Impulse);
        Debug.Log("Valor launchAngle: "+launchAngle);
    }
   }
}
