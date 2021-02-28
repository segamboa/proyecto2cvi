using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Figuras : MonoBehaviour
{
    float xSpread=10;
    float zSpread=10;
    float yOffset=14;

    float moveSpeed;
    Color myColor;
    float gFloat=255f;
    float bFloat=255f;
    float aFloat;
    float rFloat=255f;

    
    Vector3 centro = new Vector3(20,0,20);
    GameObject avion1;
    GameObject avion2;
    GameObject espada1;
    GameObject espadaC;
    GameObject espadaC1;

    Keyframe[] frames;
    AnimationCurve anim;

    float rotSpeed=0.5f;
    bool rotateClockwise=true;

    float timer = 0;

    GameObject createAirplane(Vector3 position){
        GameObject nucleo = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        nucleo.transform.position = position;
        nucleo.transform.localScale = new Vector3(0.68f,2.8f,1);
        nucleo.transform.rotation *= Quaternion.Euler(0,0,90);
        nucleo.GetComponent<Renderer>().material.color = new Color(255f,255f,255f);

        GameObject ala = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        ala.transform.parent = nucleo.transform;
        ala.transform.rotation *= Quaternion.Euler(0,90,90);
        ala.transform.localPosition = new Vector3(0,-0.429f,0);
        ala.transform.localScale = new Vector3(0.17f,3.4f,0.35f);
        ala.GetComponent<Renderer>().material.color = new Color(254f/255f,254f/255f,254f/255f);

        GameObject helice1 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        helice1.transform.parent = nucleo.transform;
        helice1.transform.rotation *= Quaternion.Euler(0,0,90);
        helice1.transform.localPosition = new Vector3(0,-0.61f,-1.25f);
        helice1.transform.localScale = new Vector3(0.5f/0.68f,0.05f/2.8f,0.5f);
        helice1.GetComponent<Renderer>().material.color = Color.white;

        GameObject helice2 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        helice2.transform.parent = nucleo.transform;
        helice2.transform.rotation *= Quaternion.Euler(0,0,90);
        helice2.transform.localPosition = new Vector3(0,-0.61f,1.25f);
        helice2.transform.localScale = new Vector3(0.5f/0.68f,0.05f/2.8f,0.5f);
        helice2.GetComponent<Renderer>().material.color = Color.white;

        GameObject cola1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cola1.transform.parent = nucleo.transform;
        cola1.transform.rotation *= Quaternion.Euler(0,0,-254.51f);
        cola1.transform.localPosition = new Vector3(0.57f,0.671f,0);
        cola1.transform.localScale = new Vector3(0.4f,0.6f,0.1f);
        cola1.GetComponent<Renderer>().material.color = new Color(254f/255f,254f/255f,254f/255f);

        GameObject cola2 = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        cola2.transform.parent = nucleo.transform;
        cola2.transform.rotation *= Quaternion.Euler(90,0,0);
        cola2.transform.localPosition = new Vector3(0,0.706f,0);
        cola2.transform.localScale = new Vector3(0.3f,1.4f,0.1f);
        cola2.GetComponent<Renderer>().material.color = new Color(254f/255f,254f/255f,254f/255f);

        return nucleo;
    }

    GameObject createSword(Vector3 position){
        GameObject nucleo = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        nucleo.transform.position = position;
        nucleo.transform.localScale = new Vector3(0.06f,1.5f,0.25f);
        //nucleo.transform.rotation *= Quaternion.Euler(0,0,90);
        nucleo.GetComponent<Renderer>().material.color = new Color(254f,254f,254f);;

        GameObject mango = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        mango.transform.parent = nucleo.transform;
        //ala.transform.rotation *= Quaternion.Euler(0,90,90);
        mango.transform.localPosition = new Vector3(0,0.768f,0);
        mango.transform.localScale = new Vector3(1,0.4f,1);
        mango.GetComponent<Renderer>().material.color = new Color(254f/255f,254f/255f,254f/255f);

        GameObject mango1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        mango1.transform.parent = nucleo.transform;
        //mango1.transform.rotation *= Quaternion.Euler(0,0,90);
        mango1.transform.localPosition = new Vector3(0,0.633f,0);
        mango1.transform.localScale = new Vector3(3.33f,0.0467f,4.6f);
        mango1.GetComponent<Renderer>().material.color = new Color(43f/255f,45f/255f,66f/255f);;

        GameObject circulo = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        circulo.transform.parent = nucleo.transform;
        circulo.transform.rotation *= Quaternion.Euler(0,0,90);
        circulo.transform.localPosition = new Vector3(0,1.186f,0);
        circulo.transform.localScale = new Vector3(0.2f,0.5f,1.2f);
        circulo.GetComponent<Renderer>().material.color = new Color(254f/255f,254f/255f,254f/255f);

        nucleo.transform.localScale = new Vector3(0.06f*2.5f,1.5f*2.5f,0.25f*2.5f);
        //nucleo.transform.position = new Vector3(0.28f,10,14.28f);
        return nucleo;
    }

    void generaCuadro(){
        espadaC = createSword(new Vector3(40.11f,10.5f,1.07f));
        espadaC.transform.rotation*=Quaternion.Euler(-135,-90,0);
        espadaC1 = createSword(new Vector3(32.65f,9.84f,1.07f));
        espadaC1.transform.rotation*=Quaternion.Euler(45,-90,0);
        GameObject cuadro = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cuadro.transform.localScale=new Vector3(21.896f,8.689f,1.25f);
        cuadro.transform.position = new Vector3(36.17f,9.65f,0.4f);
        cuadro.GetComponent<Renderer>().material.color = Color.black;

    }

    GameObject createCandle(Vector3 position){
        GameObject nucleo = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        nucleo.transform.position = position;
        nucleo.transform.localScale = new Vector3(0.88f,1f,0.88f);
        //nucleo.transform.rotation *= Quaternion.Euler(0,0,90);
        nucleo.GetComponent<Renderer>().material.color = new Color(255f,255f,255f);

        GameObject cylinder1 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        cylinder1.transform.parent = nucleo.transform;
        cylinder1.transform.localPosition = new Vector3(0,-1,0);
        cylinder1.transform.localScale = new Vector3(2,0.24f,2);
        cylinder1.GetComponent<Renderer>().material.color = new Color(43f/255f,45f/255f,66f/255f);

        GameObject cylinder2 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        cylinder2.transform.parent = nucleo.transform;
        //mango1.transform.rotation *= Quaternion.Euler(0,0,90);
        cylinder2.transform.localPosition = new Vector3(0,-0.695f,0);
        cylinder2.transform.localScale = new Vector3(1.8f,0.01f,1.8f);
        cylinder2.GetComponent<Renderer>().material.color = new Color(43f/255f,45f/255f,66f/255f);

        GameObject fire = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        fire.transform.parent = nucleo.transform;
        fire.transform.localPosition = new Vector3(0,1.39f,0);
        fire.transform.localScale = new Vector3(0.5f,1.4f,0.5f);
        fire.GetComponent<Renderer>().material.color = new Color(255f/255f,93f/255f,6f/255f);

        //nucleo.transform.localScale = new Vector3(0.06f*2.5f,1.5f*2.5f,0.25f*2.5f);
        //nucleo.transform.position = new Vector3(0.28f,10,14.28f);
        return nucleo;
    }


   void createWall(Vector3 position, float x, float y, float z, float xScale,float yScale){
        GameObject pared1 = GameObject.CreatePrimitive(PrimitiveType.Quad);
        pared1.transform.position = position;
        pared1.transform.rotation *= Quaternion.Euler(x,y,z);
        pared1.transform.localScale = new Vector3(xScale,yScale,1);
        pared1.GetComponent<Renderer>().material.color = new Color(255f/255f,224f/255f,181f/255f);
        //return pared1;
    }

    void createBed(){
        GameObject bed = GameObject.CreatePrimitive(PrimitiveType.Cube);
        bed.transform.position = new Vector3(20,3,32.5f);
        bed.transform.localScale = new Vector3(40,3.75f,15);
        bed.GetComponent<Renderer>().material.color = new Color(198f/255f,171f/255f,126f/255f);

        GameObject pillow = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        pillow.transform.position = new Vector3(4.5f,5.75f,32.5f);
        pillow.transform.localScale = new Vector3(7,7.5f,3);
        pillow.transform.rotation *= Quaternion.Euler(90,0,-10.314f);
        pillow.GetComponent<Renderer>().material.color = new Color(255f,255f,255f);

        GameObject blanket = GameObject.CreatePrimitive(PrimitiveType.Cube);
        blanket.transform.position = new Vector3(24.75f,5,32.5f);
        blanket.transform.localScale = new Vector3(30,0.2f,15);
        blanket.GetComponent<Renderer>().material.color = new Color(226f/255f,169f/255f,75f/255f);

        GameObject desk = GameObject.CreatePrimitive(PrimitiveType.Cube);
        desk.transform.position = new Vector3(3.32f,2.36f,20.56f);
        desk.transform.localScale = new Vector3(6.5f,4.5f,7.5f);
        desk.GetComponent<Renderer>().material.color = new Color(43f/255f,45f/255f,66f/255f);

        GameObject carpet = GameObject.CreatePrimitive(PrimitiveType.Cube);
        carpet.transform.position = new Vector3(31.33f,0.18f,12.81f);
        carpet.transform.localScale = new Vector3(34.636f,0.0674f,23.501f);

    }

    float horizObl=1f;
    float vertObl=-1.4f;
    void SetObliqueness() {
        Matrix4x4 mat  = Camera.main.projectionMatrix;
        mat[0, 2] = horizObl;
        mat[1, 2] = vertObl;
        Camera.main.projectionMatrix = mat;
    }


    void Start()
    {
        //SetObliqueness();
        createWall(new Vector3(0,7.5f,20),0,-90,0,40,15);
        createWall(new Vector3(25,7.5f,0),0,-180,0,50,15);
        createWall(new Vector3(25,0,20),90,0,0,50,40);
        createWall(new Vector3(25,7.5f,40),0,0,0,50,15);
        createWall(new Vector3(50,7.5f,25),0,90,0,30,15);
        avion1=createAirplane(new Vector3(16.67f,13.6f,16.4f));
        avion1.transform.rotation*=Quaternion.Euler(-90,0,0);
        createBed();
        espada1 =createSword(new Vector3(0.28f,10,14.28f));
        espada1.transform.rotation*=Quaternion.Euler(180,0,0);
        createCandle(new Vector3(2.06f,5.9f,22.18f));
        generaCuadro();
        avion2=createAirplane(new Vector3(6.48f,0.96f,5.31f));
        moveSpeed=5f;
        aFloat = 1;

        frames = new Keyframe[29];
        for(int i = 1; i<30;i++){
            frames[i-1] = new Keyframe(i,Mathf.PI/6);
        }
        anim= new AnimationCurve(frames);
        
    }

    void Rotate(){
        if(rotateClockwise){
            float x = -Mathf.Cos(timer)*xSpread;
            float z = Mathf.Sin(timer)*zSpread;
            Vector3 pos = new Vector3(x,yOffset,z);
            avion1.transform.position = pos+centro;
        }
        else{
            float x = Mathf.Cos(timer)*xSpread;
            float z = Mathf.Sin(timer)*zSpread;
            Vector3 pos = new Vector3(x,yOffset,z);
            avion1.transform.position = pos+centro;
        }
    }

    // Update is called once per frame
    void FixedUpdate() 
    {
        timer+=Time.deltaTime*rotSpeed;
        if(Time.time <=29){
        espada1.transform.Rotate(new Vector3(anim.Evaluate(Time.time),espada1.transform.rotation.y, espada1.transform.rotation.z));
        espadaC.transform.Rotate(new Vector3(-anim.Evaluate(Time.time),espada1.transform.rotation.y, espada1.transform.rotation.z));
        espadaC1.transform.Rotate(new Vector3(anim.Evaluate(Time.time),espada1.transform.rotation.y, espada1.transform.rotation.z));
        Rotate();
        avion1.transform.rotation*= Quaternion.Euler(0.575f,0,0);
        }


        if(Input.GetKey(KeyCode.Z)){
            if(aFloat<1){
                aFloat += 0.005f;
            }
            else{
                aFloat =0;
            }
        }
        if(Input.GetKey(KeyCode.X)){
            if(rFloat<1){
                rFloat += 0.005f;
            }
            else{
                rFloat =0;
            }
        }
        if(Input.GetKey(KeyCode.C)){
            if(gFloat<1){
                gFloat += 0.005f;
            }
            else{
                gFloat =0;
            }
        }
        if(Input.GetKey(KeyCode.V)){
            if(bFloat<1){
                bFloat += 0.005f;
            }
            else{
                bFloat =0;
            }
        }

        if (Input.GetKey(KeyCode.A))
            avion2.transform.Rotate(Vector3.left * moveSpeed* 5 * Time.deltaTime);
      
        if (Input.GetKey(KeyCode.D))
            avion2.transform.Rotate(Vector3.right * moveSpeed* 5 * Time.deltaTime);


        myColor = new Color(rFloat, gFloat, bFloat, aFloat);
        Transform[] childTransforms = avion2.GetComponentsInChildren<Transform>();
        childTransforms[0].GetComponent<Renderer>().material.color = myColor;
        if (Input.GetKey(KeyCode.W))
            avion2.transform.Translate(0f,-Time.deltaTime*moveSpeed, 0f);
        if (Input.GetKey(KeyCode.S))
            avion2.transform.Translate(0f,Time.deltaTime*moveSpeed, 0f);
        
    }
}
