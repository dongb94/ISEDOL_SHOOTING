using UnityEngine;

namespace Bullet
{
	public enum BulletType
	{
		normal,		// 기본 탄환
		nose,		// 왁굳형 코
		axe,		// 아이네 도끼
		burger,		// 징버거 햄버거
		sound_wave,	// 릴파님 초음파
		heart,		// 주르르 하트
		hair_pin,	// 고세구 머리핀
		sword,		// 비챤님 다이아검
		end
	}

	// 탄환 오브젝트 (타격 불가 판정)
	public class Bullet : MonoBehaviour
	{
		private BulletType _type;

		// 탄환의 종류를 설정  
		public void Init(BulletType bType = BulletType.normal)
		{
			
		}
		
		/// <summary> 탄환을 지정된 위치에 소환 </summary>
		/// <param name="pos">생성 위치</param>
		public int Spawn(Vector2 pos)
		{
			transform.position = pos;

			return 0;
		}

		/// <summary> 탄환을 정해진 방향으로 발사 </summary>
		/// <param name="dir">발사 방향</param>
		/// <param name="spd">발사 속도</param>
		public int Fire(Vector2 dir, Vector2 spd)
		{

			return 0;
		}
	}
}