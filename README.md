# UnityGH

Connect grasshopper3d and Unity by UDP and display mesh on Unity.

## About Data

* UnityGH.gh file is sample grassshopper data. There are a modeling part and the UDP operation part of the data. Because it use gHowl for UDP, please download it from Food4Rhino.  
* UDPMesh.cs file is the part of UDPreceiver in Unity.
* GHMesh.cs file makes mesh in Unity from the data which Unity received from grasshopper.  
* Grasshopper send to Unity with vertex coordinates as Comma Separated Value and generate mesh on Unity based on the information.

## Reference

* grasshopper UDP tool : [gHowl](https://www.food4rhino.com/app/ghowl).
* UDPreceiver in Unity : [UnityでUDPを受信してみる](https://qiita.com/nenjiru/items/8fa8dfb27f55c0205651). 
* The YoutubeMovie which I referred to : [Grasshopper Mesh Streaming To Unity AR](https://youtu.be/krWW12V9y8M)

## Contact

When you want to know the details more, give me DM easily in [twitter.](https://twitter.com/hiron_rgkr)  
詳細を知りたい場合は、気軽に[twitter](https://twitter.com/hiron_rgkr)でDMください。
