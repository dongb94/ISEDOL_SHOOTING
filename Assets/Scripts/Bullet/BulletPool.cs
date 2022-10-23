using BDG;
using UnityEngine;

namespace Bullet
{
	// Bullet Object Pool
	public class BulletPool : AbstractPrefabPoolingManager<Bullet>
	{
		protected override void OnCreate(Bullet obj)
		{
			
		}

		protected override void OnActive(Bullet obj)
		{
		}

		protected override void OnPooled(Bullet obj)
		{
		}

		public override UnityPrefabObjectPool<Bullet> Initialize()
		{
			prefabName = "Bullet";
			return base.Initialize();
		}
	}
}