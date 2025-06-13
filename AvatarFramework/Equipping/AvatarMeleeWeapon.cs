using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.NPCs;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework.Equipping
{
	// Token: 0x02000624 RID: 1572
	public class AvatarMeleeWeapon : AvatarWeapon
	{
		// Token: 0x06008989 RID: 35209 RVA: 0x00247294 File Offset: 0x00245494
		// Note: this type is marked as 'beforefieldinit'.
		static AvatarMeleeWeapon()
		{
			Il2CppClassPointerStore<AvatarMeleeWeapon>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Equipping", "AvatarMeleeWeapon");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarMeleeWeapon>.NativeClassPtr);
			AvatarMeleeWeapon.NativeFieldInfoPtr_GruntChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarMeleeWeapon>.NativeClassPtr, "GruntChance");
			AvatarMeleeWeapon.NativeFieldInfoPtr_AttackSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarMeleeWeapon>.NativeClassPtr, "AttackSound");
			AvatarMeleeWeapon.NativeFieldInfoPtr_HitSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarMeleeWeapon>.NativeClassPtr, "HitSound");
			AvatarMeleeWeapon.NativeFieldInfoPtr_AttackRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarMeleeWeapon>.NativeClassPtr, "AttackRange");
			AvatarMeleeWeapon.NativeFieldInfoPtr_AttackRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarMeleeWeapon>.NativeClassPtr, "AttackRadius");
			AvatarMeleeWeapon.NativeFieldInfoPtr_Damage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarMeleeWeapon>.NativeClassPtr, "Damage");
			AvatarMeleeWeapon.NativeFieldInfoPtr_Attacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarMeleeWeapon>.NativeClassPtr, "Attacks");
			AvatarMeleeWeapon.NativeFieldInfoPtr_attackRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarMeleeWeapon>.NativeClassPtr, "attackRoutine");
			AvatarMeleeWeapon.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarMeleeWeapon>.NativeClassPtr, 100680559);
			AvatarMeleeWeapon.NativeMethodInfoPtr_Attack_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarMeleeWeapon>.NativeClassPtr, 100680560);
			AvatarMeleeWeapon.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarMeleeWeapon>.NativeClassPtr, 100680561);
		}

		// Token: 0x0600898A RID: 35210 RVA: 0x002473A0 File Offset: 0x002455A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255465, XrefRangeEnd = 255477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Unequip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AvatarMeleeWeapon.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600898B RID: 35211 RVA: 0x002473DC File Offset: 0x002455DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255477, XrefRangeEnd = 255502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Attack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AvatarMeleeWeapon.NativeMethodInfoPtr_Attack_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600898C RID: 35212 RVA: 0x00247418 File Offset: 0x00245618
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255502, XrefRangeEnd = 255503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvatarMeleeWeapon() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarMeleeWeapon>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarMeleeWeapon.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600898D RID: 35213 RVA: 0x000412EB File Offset: 0x0003F4EB
		public AvatarMeleeWeapon(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002995 RID: 10645
		// (get) Token: 0x0600898E RID: 35214 RVA: 0x00247454 File Offset: 0x00245654
		// (set) Token: 0x0600898F RID: 35215 RVA: 0x000412F4 File Offset: 0x0003F4F4
		public unsafe static float GruntChance
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(AvatarMeleeWeapon.NativeFieldInfoPtr_GruntChance, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AvatarMeleeWeapon.NativeFieldInfoPtr_GruntChance, (void*)(&value));
			}
		}

		// Token: 0x17002996 RID: 10646
		// (get) Token: 0x06008990 RID: 35216 RVA: 0x00247470 File Offset: 0x00245670
		// (set) Token: 0x06008991 RID: 35217 RVA: 0x00041302 File Offset: 0x0003F502
		public unsafe AudioSourceController AttackSound
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.NativeFieldInfoPtr_AttackSound);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.NativeFieldInfoPtr_AttackSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002997 RID: 10647
		// (get) Token: 0x06008992 RID: 35218 RVA: 0x002474A0 File Offset: 0x002456A0
		// (set) Token: 0x06008993 RID: 35219 RVA: 0x00041321 File Offset: 0x0003F521
		public unsafe AudioSourceController HitSound
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.NativeFieldInfoPtr_HitSound);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.NativeFieldInfoPtr_HitSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002998 RID: 10648
		// (get) Token: 0x06008994 RID: 35220 RVA: 0x002474D0 File Offset: 0x002456D0
		// (set) Token: 0x06008995 RID: 35221 RVA: 0x00041340 File Offset: 0x0003F540
		public unsafe float AttackRange
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.NativeFieldInfoPtr_AttackRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.NativeFieldInfoPtr_AttackRange)) = value;
			}
		}

		// Token: 0x17002999 RID: 10649
		// (get) Token: 0x06008996 RID: 35222 RVA: 0x002474F8 File Offset: 0x002456F8
		// (set) Token: 0x06008997 RID: 35223 RVA: 0x0004135B File Offset: 0x0003F55B
		public unsafe float AttackRadius
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.NativeFieldInfoPtr_AttackRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.NativeFieldInfoPtr_AttackRadius)) = value;
			}
		}

		// Token: 0x1700299A RID: 10650
		// (get) Token: 0x06008998 RID: 35224 RVA: 0x00247520 File Offset: 0x00245720
		// (set) Token: 0x06008999 RID: 35225 RVA: 0x00041376 File Offset: 0x0003F576
		public unsafe float Damage
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.NativeFieldInfoPtr_Damage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.NativeFieldInfoPtr_Damage)) = value;
			}
		}

		// Token: 0x1700299B RID: 10651
		// (get) Token: 0x0600899A RID: 35226 RVA: 0x00247548 File Offset: 0x00245748
		// (set) Token: 0x0600899B RID: 35227 RVA: 0x00041391 File Offset: 0x0003F591
		public unsafe Il2CppReferenceArray<AvatarMeleeWeapon.MeleeAttack> Attacks
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.NativeFieldInfoPtr_Attacks);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AvatarMeleeWeapon.MeleeAttack>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.NativeFieldInfoPtr_Attacks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700299C RID: 10652
		// (get) Token: 0x0600899C RID: 35228 RVA: 0x00247578 File Offset: 0x00245778
		// (set) Token: 0x0600899D RID: 35229 RVA: 0x000413B0 File Offset: 0x0003F5B0
		public unsafe Coroutine attackRoutine
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.NativeFieldInfoPtr_attackRoutine);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.NativeFieldInfoPtr_attackRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005D99 RID: 23961
		private static readonly System.IntPtr NativeFieldInfoPtr_GruntChance;

		// Token: 0x04005D9A RID: 23962
		private static readonly System.IntPtr NativeFieldInfoPtr_AttackSound;

		// Token: 0x04005D9B RID: 23963
		private static readonly System.IntPtr NativeFieldInfoPtr_HitSound;

		// Token: 0x04005D9C RID: 23964
		private static readonly System.IntPtr NativeFieldInfoPtr_AttackRange;

		// Token: 0x04005D9D RID: 23965
		private static readonly System.IntPtr NativeFieldInfoPtr_AttackRadius;

		// Token: 0x04005D9E RID: 23966
		private static readonly System.IntPtr NativeFieldInfoPtr_Damage;

		// Token: 0x04005D9F RID: 23967
		private static readonly System.IntPtr NativeFieldInfoPtr_Attacks;

		// Token: 0x04005DA0 RID: 23968
		private static readonly System.IntPtr NativeFieldInfoPtr_attackRoutine;

		// Token: 0x04005DA1 RID: 23969
		private static readonly System.IntPtr NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0;

		// Token: 0x04005DA2 RID: 23970
		private static readonly System.IntPtr NativeMethodInfoPtr_Attack_Public_Virtual_Void_0;

		// Token: 0x04005DA3 RID: 23971
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B45 RID: 2885
		[System.Serializable]
		public class MeleeAttack : Il2CppSystem.Object
		{
			// Token: 0x0600DAF3 RID: 56051 RVA: 0x00344C38 File Offset: 0x00342E38
			// Note: this type is marked as 'beforefieldinit'.
			static MeleeAttack()
			{
				Il2CppClassPointerStore<AvatarMeleeWeapon.MeleeAttack>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AvatarMeleeWeapon>.NativeClassPtr, "MeleeAttack");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarMeleeWeapon.MeleeAttack>.NativeClassPtr);
				AvatarMeleeWeapon.MeleeAttack.NativeFieldInfoPtr_RangeMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarMeleeWeapon.MeleeAttack>.NativeClassPtr, "RangeMultiplier");
				AvatarMeleeWeapon.MeleeAttack.NativeFieldInfoPtr_DamageMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarMeleeWeapon.MeleeAttack>.NativeClassPtr, "DamageMultiplier");
				AvatarMeleeWeapon.MeleeAttack.NativeFieldInfoPtr_AnimationTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarMeleeWeapon.MeleeAttack>.NativeClassPtr, "AnimationTrigger");
				AvatarMeleeWeapon.MeleeAttack.NativeFieldInfoPtr_DamageDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarMeleeWeapon.MeleeAttack>.NativeClassPtr, "DamageDelay");
				AvatarMeleeWeapon.MeleeAttack.NativeFieldInfoPtr_AttackSoundDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarMeleeWeapon.MeleeAttack>.NativeClassPtr, "AttackSoundDelay");
				AvatarMeleeWeapon.MeleeAttack.NativeFieldInfoPtr_AttackClips = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarMeleeWeapon.MeleeAttack>.NativeClassPtr, "AttackClips");
				AvatarMeleeWeapon.MeleeAttack.NativeFieldInfoPtr_HitClips = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarMeleeWeapon.MeleeAttack>.NativeClassPtr, "HitClips");
				AvatarMeleeWeapon.MeleeAttack.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarMeleeWeapon.MeleeAttack>.NativeClassPtr, 100680562);
			}

			// Token: 0x0600DAF4 RID: 56052 RVA: 0x00344D04 File Offset: 0x00342F04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255413, XrefRangeEnd = 255417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MeleeAttack() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarMeleeWeapon.MeleeAttack>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarMeleeWeapon.MeleeAttack.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DAF5 RID: 56053 RVA: 0x0006A366 File Offset: 0x00068566
			public MeleeAttack(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700438A RID: 17290
			// (get) Token: 0x0600DAF6 RID: 56054 RVA: 0x00344D40 File Offset: 0x00342F40
			// (set) Token: 0x0600DAF7 RID: 56055 RVA: 0x0006A36F File Offset: 0x0006856F
			public unsafe float RangeMultiplier
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.MeleeAttack.NativeFieldInfoPtr_RangeMultiplier);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.MeleeAttack.NativeFieldInfoPtr_RangeMultiplier)) = value;
				}
			}

			// Token: 0x1700438B RID: 17291
			// (get) Token: 0x0600DAF8 RID: 56056 RVA: 0x00344D68 File Offset: 0x00342F68
			// (set) Token: 0x0600DAF9 RID: 56057 RVA: 0x0006A38A File Offset: 0x0006858A
			public unsafe float DamageMultiplier
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.MeleeAttack.NativeFieldInfoPtr_DamageMultiplier);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.MeleeAttack.NativeFieldInfoPtr_DamageMultiplier)) = value;
				}
			}

			// Token: 0x1700438C RID: 17292
			// (get) Token: 0x0600DAFA RID: 56058 RVA: 0x00344D90 File Offset: 0x00342F90
			// (set) Token: 0x0600DAFB RID: 56059 RVA: 0x0006A3A5 File Offset: 0x000685A5
			public unsafe string AnimationTrigger
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.MeleeAttack.NativeFieldInfoPtr_AnimationTrigger);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.MeleeAttack.NativeFieldInfoPtr_AnimationTrigger), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700438D RID: 17293
			// (get) Token: 0x0600DAFC RID: 56060 RVA: 0x00344DB8 File Offset: 0x00342FB8
			// (set) Token: 0x0600DAFD RID: 56061 RVA: 0x0006A3C4 File Offset: 0x000685C4
			public unsafe float DamageDelay
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.MeleeAttack.NativeFieldInfoPtr_DamageDelay);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.MeleeAttack.NativeFieldInfoPtr_DamageDelay)) = value;
				}
			}

			// Token: 0x1700438E RID: 17294
			// (get) Token: 0x0600DAFE RID: 56062 RVA: 0x00344DE0 File Offset: 0x00342FE0
			// (set) Token: 0x0600DAFF RID: 56063 RVA: 0x0006A3DF File Offset: 0x000685DF
			public unsafe float AttackSoundDelay
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.MeleeAttack.NativeFieldInfoPtr_AttackSoundDelay);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.MeleeAttack.NativeFieldInfoPtr_AttackSoundDelay)) = value;
				}
			}

			// Token: 0x1700438F RID: 17295
			// (get) Token: 0x0600DB00 RID: 56064 RVA: 0x00344E08 File Offset: 0x00343008
			// (set) Token: 0x0600DB01 RID: 56065 RVA: 0x0006A3FA File Offset: 0x000685FA
			public unsafe Il2CppReferenceArray<AudioClip> AttackClips
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.MeleeAttack.NativeFieldInfoPtr_AttackClips);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.MeleeAttack.NativeFieldInfoPtr_AttackClips), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004390 RID: 17296
			// (get) Token: 0x0600DB02 RID: 56066 RVA: 0x00344E38 File Offset: 0x00343038
			// (set) Token: 0x0600DB03 RID: 56067 RVA: 0x0006A419 File Offset: 0x00068619
			public unsafe Il2CppReferenceArray<AudioClip> HitClips
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.MeleeAttack.NativeFieldInfoPtr_HitClips);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.MeleeAttack.NativeFieldInfoPtr_HitClips), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400935E RID: 37726
			private static readonly System.IntPtr NativeFieldInfoPtr_RangeMultiplier;

			// Token: 0x0400935F RID: 37727
			private static readonly System.IntPtr NativeFieldInfoPtr_DamageMultiplier;

			// Token: 0x04009360 RID: 37728
			private static readonly System.IntPtr NativeFieldInfoPtr_AnimationTrigger;

			// Token: 0x04009361 RID: 37729
			private static readonly System.IntPtr NativeFieldInfoPtr_DamageDelay;

			// Token: 0x04009362 RID: 37730
			private static readonly System.IntPtr NativeFieldInfoPtr_AttackSoundDelay;

			// Token: 0x04009363 RID: 37731
			private static readonly System.IntPtr NativeFieldInfoPtr_AttackClips;

			// Token: 0x04009364 RID: 37732
			private static readonly System.IntPtr NativeFieldInfoPtr_HitClips;

			// Token: 0x04009365 RID: 37733
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000B46 RID: 2886
		[ObfuscatedName("ScheduleOne.AvatarFramework.Equipping.AvatarMeleeWeapon+<>c__DisplayClass10_0")]
		public sealed class __c__DisplayClass10_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DB04 RID: 56068 RVA: 0x00344E68 File Offset: 0x00343068
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass10_0()
			{
				Il2CppClassPointerStore<AvatarMeleeWeapon.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AvatarMeleeWeapon>.NativeClassPtr, "<>c__DisplayClass10_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarMeleeWeapon.__c__DisplayClass10_0>.NativeClassPtr);
				AvatarMeleeWeapon.__c__DisplayClass10_0.NativeFieldInfoPtr_attack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarMeleeWeapon.__c__DisplayClass10_0>.NativeClassPtr, "attack");
				AvatarMeleeWeapon.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarMeleeWeapon.__c__DisplayClass10_0>.NativeClassPtr, "<>4__this");
				AvatarMeleeWeapon.__c__DisplayClass10_0.NativeFieldInfoPtr_npc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarMeleeWeapon.__c__DisplayClass10_0>.NativeClassPtr, "npc");
				AvatarMeleeWeapon.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarMeleeWeapon.__c__DisplayClass10_0>.NativeClassPtr, 100680563);
				AvatarMeleeWeapon.__c__DisplayClass10_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarMeleeWeapon.__c__DisplayClass10_0>.NativeClassPtr, 100680564);
			}

			// Token: 0x0600DB05 RID: 56069 RVA: 0x00344EF8 File Offset: 0x003430F8
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass10_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarMeleeWeapon.__c__DisplayClass10_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarMeleeWeapon.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DB06 RID: 56070 RVA: 0x00344F34 File Offset: 0x00343134
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255460, XrefRangeEnd = 255465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarMeleeWeapon.__c__DisplayClass10_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}

			// Token: 0x0600DB07 RID: 56071 RVA: 0x0006A438 File Offset: 0x00068638
			public __c__DisplayClass10_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004391 RID: 17297
			// (get) Token: 0x0600DB08 RID: 56072 RVA: 0x00344F74 File Offset: 0x00343174
			// (set) Token: 0x0600DB09 RID: 56073 RVA: 0x0006A441 File Offset: 0x00068641
			public unsafe AvatarMeleeWeapon.MeleeAttack attack
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.__c__DisplayClass10_0.NativeFieldInfoPtr_attack);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarMeleeWeapon.MeleeAttack>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.__c__DisplayClass10_0.NativeFieldInfoPtr_attack), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004392 RID: 17298
			// (get) Token: 0x0600DB0A RID: 56074 RVA: 0x00344FA4 File Offset: 0x003431A4
			// (set) Token: 0x0600DB0B RID: 56075 RVA: 0x0006A460 File Offset: 0x00068660
			public unsafe AvatarMeleeWeapon __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarMeleeWeapon>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004393 RID: 17299
			// (get) Token: 0x0600DB0C RID: 56076 RVA: 0x00344FD4 File Offset: 0x003431D4
			// (set) Token: 0x0600DB0D RID: 56077 RVA: 0x0006A47F File Offset: 0x0006867F
			public unsafe NPC npc
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.__c__DisplayClass10_0.NativeFieldInfoPtr_npc);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.__c__DisplayClass10_0.NativeFieldInfoPtr_npc), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009366 RID: 37734
			private static readonly System.IntPtr NativeFieldInfoPtr_attack;

			// Token: 0x04009367 RID: 37735
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009368 RID: 37736
			private static readonly System.IntPtr NativeFieldInfoPtr_npc;

			// Token: 0x04009369 RID: 37737
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400936A RID: 37738
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000CC4 RID: 3268
			[ObfuscatedName("ScheduleOne.AvatarFramework.Equipping.AvatarMeleeWeapon+<>c__DisplayClass10_0+<<Attack>g__AttackRoutine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600EA3D RID: 59965 RVA: 0x00370AAC File Offset: 0x0036ECAC
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<AvatarMeleeWeapon.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AvatarMeleeWeapon.__c__DisplayClass10_0>.NativeClassPtr, "<<Attack>g__AttackRoutine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarMeleeWeapon.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					AvatarMeleeWeapon.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarMeleeWeapon.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					AvatarMeleeWeapon.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarMeleeWeapon.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					AvatarMeleeWeapon.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarMeleeWeapon.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					AvatarMeleeWeapon.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarMeleeWeapon.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100680565);
					AvatarMeleeWeapon.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarMeleeWeapon.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100680566);
					AvatarMeleeWeapon.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarMeleeWeapon.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100680567);
					AvatarMeleeWeapon.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarMeleeWeapon.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100680568);
					AvatarMeleeWeapon.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarMeleeWeapon.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100680569);
					AvatarMeleeWeapon.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarMeleeWeapon.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100680570);
				}

				// Token: 0x0600EA3E RID: 59966 RVA: 0x00370B8C File Offset: 0x0036ED8C
				[CallerCount(54)]
				[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarMeleeWeapon.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
					*ptr = ref <>1__state;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarMeleeWeapon.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600EA3F RID: 59967 RVA: 0x00370BD4 File Offset: 0x0036EDD4
				[CallerCount(14558)]
				[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarMeleeWeapon.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600EA40 RID: 59968 RVA: 0x00370C08 File Offset: 0x0036EE08
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255417, XrefRangeEnd = 255455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AvatarMeleeWeapon.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}

				// Token: 0x17004874 RID: 18548
				// (get) Token: 0x0600EA41 RID: 59969 RVA: 0x00370C44 File Offset: 0x0036EE44
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarMeleeWeapon.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600EA42 RID: 59970 RVA: 0x00370C84 File Offset: 0x0036EE84
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255455, XrefRangeEnd = 255460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarMeleeWeapon.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x17004875 RID: 18549
				// (get) Token: 0x0600EA43 RID: 59971 RVA: 0x00370CB8 File Offset: 0x0036EEB8
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarMeleeWeapon.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600EA44 RID: 59972 RVA: 0x00071E6A File Offset: 0x0007006A
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(System.IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004871 RID: 18545
				// (get) Token: 0x0600EA45 RID: 59973 RVA: 0x00370CF8 File Offset: 0x0036EEF8
				// (set) Token: 0x0600EA46 RID: 59974 RVA: 0x00071E73 File Offset: 0x00070073
				public unsafe int __1__state
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004872 RID: 18546
				// (get) Token: 0x0600EA47 RID: 59975 RVA: 0x00370D20 File Offset: 0x0036EF20
				// (set) Token: 0x0600EA48 RID: 59976 RVA: 0x00071E8E File Offset: 0x0007008E
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004873 RID: 18547
				// (get) Token: 0x0600EA49 RID: 59977 RVA: 0x00370D50 File Offset: 0x0036EF50
				// (set) Token: 0x0600EA4A RID: 59978 RVA: 0x00071EAD File Offset: 0x000700AD
				public unsafe AvatarMeleeWeapon.__c__DisplayClass10_0 __4__this
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarMeleeWeapon.__c__DisplayClass10_0>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarMeleeWeapon.__c__DisplayClass10_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04009CB8 RID: 40120
				private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009CB9 RID: 40121
				private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009CBA RID: 40122
				private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009CBB RID: 40123
				private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009CBC RID: 40124
				private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009CBD RID: 40125
				private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009CBE RID: 40126
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009CBF RID: 40127
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009CC0 RID: 40128
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
