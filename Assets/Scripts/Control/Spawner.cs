using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;
namespace Control{
    public class Spawner : MonoBehaviour
    {
        
        [SerializeField] private Target prefab;
        [SerializeField] private int count;
        [SerializeField] private int size;
        [SerializeField] private int maxSize;

        private ObjectPool<Target> pool;
        private List<Target> targets;

         private void Start()
        {
            targets = new List<Target>();
            pool = new ObjectPool<Target>(
                ()=> {return Instantiate(prefab,transform);},
                (obj)=> obj.Reset(),
                (obj)=> obj.gameObject.SetActive(false),
                (obj)=> Destroy(obj),
                false,
                size,
                maxSize
            );
        }
    
        public void Spawn(){
            for( int i=0;i<count;i++){
                var target = pool.Get();
                target.Init(Kill);
                targets.Add(target);
            }
        }
        public void Deactivate(){
            for( int i=0;i<targets.Count;i++){
                pool.Release(targets[i]);
            }
            targets.Clear();
        }
        public void Kill(Target toBeReleased){
            pool.Release(toBeReleased);
        }
    }
}