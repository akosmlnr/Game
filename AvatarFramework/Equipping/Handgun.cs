using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework.Equipping
{
	// Token: 0x02000627 RID: 1575
	public class Handgun : AvatarRangedWeapon
	{
		// Token: 0x060089EB RID: 35307 RVA: 0x002482A0 File Offset: 0x002464A0
		// Note: this type is marked as 'beforefieldinit'.
		static Handgun()
		{
			Il2CppClassPointerStore<Handgun>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Equipping", "Handgun");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Handgun>.NativeClassPtr);
			Handgun.NativeFieldInfoPtr_Anim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Handgun>.NativeClassPtr, "Anim");
			Handgun.NativeFieldInfoPtr_ShellParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Handgun>.NativeClassPtr, "ShellParticles");
			Handgun.NativeFieldInfoPtr_SmokeParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Handgun>.NativeClassPtr, "SmokeParticles");
			Handgun.NativeFieldInfoPtr_FlashObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Handgun>.NativeClassPtr, "FlashObject");
			Handgun.NativeFieldInfoPtr_RayPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Handgun>.NativeClassPtr, "RayPrefab");
			Handgun.NativeFieldInfoPtr_flashRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Handgun>.NativeClassPtr, "flashRoutine");
			Handgun.NativeMethodInfoPtr_Shoot_Public_Virtual_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Handgun>.NativeClassPtr, 100680595);
			Handgun.NativeMethodInfoPtr_Flash_Private_IEnumerator_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Handgun>.NativeClassPtr, 100680596);
			Handgun.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Handgun>.NativeClassPtr, 100680597);
		}

		// Token: 0x060089EC RID: 35308 RVA: 0x00248384 File Offset: 0x00246584
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255677, XrefRangeEnd = 255697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Shoot(Vector3 endPoint)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref endPoint;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Handgun.NativeMethodInfoPtr_Shoot_Public_Virtual_Void_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060089ED RID: 35309 RVA: 0x002483D0 File Offset: 0x002465D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255697, XrefRangeEnd = 255702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Flash(Vector3 endPoint)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref endPoint;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Handgun.NativeMethodInfoPtr_Flash_Private_IEnumerator_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x060089EE RID: 35310 RVA: 0x0024841C File Offset: 0x0024661C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255702, XrefRangeEnd = 255706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Handgun() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Handgun>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Handgun.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060089EF RID: 35311 RVA: 0x000416EC File Offset: 0x0003F8EC
		public Handgun(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170029BB RID: 10683
		// (get) Token: 0x060089F0 RID: 35312 RVA: 0x00248458 File Offset: 0x00246658
		// (set) Token: 0x060089F1 RID: 35313 RVA: 0x000416F5 File Offset: 0x0003F8F5
		public unsafe Animation Anim
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Handgun.NativeFieldInfoPtr_Anim);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Handgun.NativeFieldInfoPtr_Anim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170029BC RID: 10684
		// (get) Token: 0x060089F2 RID: 35314 RVA: 0x00248488 File Offset: 0x00246688
		// (set) Token: 0x060089F3 RID: 35315 RVA: 0x00041714 File Offset: 0x0003F914
		public unsafe ParticleSystem ShellParticles
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Handgun.NativeFieldInfoPtr_ShellParticles);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Handgun.NativeFieldInfoPtr_ShellParticles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170029BD RID: 10685
		// (get) Token: 0x060089F4 RID: 35316 RVA: 0x002484B8 File Offset: 0x002466B8
		// (set) Token: 0x060089F5 RID: 35317 RVA: 0x00041733 File Offset: 0x0003F933
		public unsafe ParticleSystem SmokeParticles
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Handgun.NativeFieldInfoPtr_SmokeParticles);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Handgun.NativeFieldInfoPtr_SmokeParticles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170029BE RID: 10686
		// (get) Token: 0x060089F6 RID: 35318 RVA: 0x002484E8 File Offset: 0x002466E8
		// (set) Token: 0x060089F7 RID: 35319 RVA: 0x00041752 File Offset: 0x0003F952
		public unsafe Transform FlashObject
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Handgun.NativeFieldInfoPtr_FlashObject);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Handgun.NativeFieldInfoPtr_FlashObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170029BF RID: 10687
		// (get) Token: 0x060089F8 RID: 35320 RVA: 0x00248518 File Offset: 0x00246718
		// (set) Token: 0x060089F9 RID: 35321 RVA: 0x00041771 File Offset: 0x0003F971
		public unsafe GameObject RayPrefab
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Handgun.NativeFieldInfoPtr_RayPrefab);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Handgun.NativeFieldInfoPtr_RayPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170029C0 RID: 10688
		// (get) Token: 0x060089FA RID: 35322 RVA: 0x00248548 File Offset: 0x00246748
		// (set) Token: 0x060089FB RID: 35323 RVA: 0x00041790 File Offset: 0x0003F990
		public unsafe Coroutine flashRoutine
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Handgun.NativeFieldInfoPtr_flashRoutine);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Handgun.NativeFieldInfoPtr_flashRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005DD1 RID: 24017
		private static readonly System.IntPtr NativeFieldInfoPtr_Anim;

		// Token: 0x04005DD2 RID: 24018
		private static readonly System.IntPtr NativeFieldInfoPtr_ShellParticles;

		// Token: 0x04005DD3 RID: 24019
		private static readonly System.IntPtr NativeFieldInfoPtr_SmokeParticles;

		// Token: 0x04005DD4 RID: 24020
		private static readonly System.IntPtr NativeFieldInfoPtr_FlashObject;

		// Token: 0x04005DD5 RID: 24021
		private static readonly System.IntPtr NativeFieldInfoPtr_RayPrefab;

		// Token: 0x04005DD6 RID: 24022
		private static readonly System.IntPtr NativeFieldInfoPtr_flashRoutine;

		// Token: 0x04005DD7 RID: 24023
		private static readonly System.IntPtr NativeMethodInfoPtr_Shoot_Public_Virtual_Void_Vector3_0;

		// Token: 0x04005DD8 RID: 24024
		private static readonly System.IntPtr NativeMethodInfoPtr_Flash_Private_IEnumerator_Vector3_0;

		// Token: 0x04005DD9 RID: 24025
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B48 RID: 2888
		[ObfuscatedName("ScheduleOne.AvatarFramework.Equipping.Handgun+<Flash>d__7")]
		public sealed class _Flash_d__7 : Il2CppSystem.Object
		{
			// Token: 0x0600DB1C RID: 56092 RVA: 0x003452D8 File Offset: 0x003434D8
			// Note: this type is marked as 'beforefieldinit'.
			static _Flash_d__7()
			{
				Il2CppClassPointerStore<Handgun._Flash_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Handgun>.NativeClassPtr, "<Flash>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Handgun._Flash_d__7>.NativeClassPtr);
				Handgun._Flash_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Handgun._Flash_d__7>.NativeClassPtr, "<>1__state");
				Handgun._Flash_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Handgun._Flash_d__7>.NativeClassPtr, "<>2__current");
				Handgun._Flash_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Handgun._Flash_d__7>.NativeClassPtr, "<>4__this");
				Handgun._Flash_d__7.NativeFieldInfoPtr_endPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Handgun._Flash_d__7>.NativeClassPtr, "endPoint");
				Handgun._Flash_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Handgun._Flash_d__7>.NativeClassPtr, 100680598);
				Handgun._Flash_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Handgun._Flash_d__7>.NativeClassPtr, 100680599);
				Handgun._Flash_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Handgun._Flash_d__7>.NativeClassPtr, 100680600);
				Handgun._Flash_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Handgun._Flash_d__7>.NativeClassPtr, 100680601);
				Handgun._Flash_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Handgun._Flash_d__7>.NativeClassPtr, 100680602);
				Handgun._Flash_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Handgun._Flash_d__7>.NativeClassPtr, 100680603);
			}

			// Token: 0x0600DB1D RID: 56093 RVA: 0x003453CC File Offset: 0x003435CC
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Flash_d__7(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Handgun._Flash_d__7>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Handgun._Flash_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DB1E RID: 56094 RVA: 0x00345414 File Offset: 0x00343614
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Handgun._Flash_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DB1F RID: 56095 RVA: 0x00345448 File Offset: 0x00343648
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255634, XrefRangeEnd = 255672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Handgun._Flash_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x1700439D RID: 17309
			// (get) Token: 0x0600DB20 RID: 56096 RVA: 0x00345484 File Offset: 0x00343684
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Handgun._Flash_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600DB21 RID: 56097 RVA: 0x003454C4 File Offset: 0x003436C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255672, XrefRangeEnd = 255677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Handgun._Flash_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x1700439E RID: 17310
			// (get) Token: 0x0600DB22 RID: 56098 RVA: 0x003454F8 File Offset: 0x003436F8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Handgun._Flash_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600DB23 RID: 56099 RVA: 0x0006A500 File Offset: 0x00068700
			public _Flash_d__7(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004399 RID: 17305
			// (get) Token: 0x0600DB24 RID: 56100 RVA: 0x00345538 File Offset: 0x00343738
			// (set) Token: 0x0600DB25 RID: 56101 RVA: 0x0006A509 File Offset: 0x00068709
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Handgun._Flash_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Handgun._Flash_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700439A RID: 17306
			// (get) Token: 0x0600DB26 RID: 56102 RVA: 0x00345560 File Offset: 0x00343760
			// (set) Token: 0x0600DB27 RID: 56103 RVA: 0x0006A524 File Offset: 0x00068724
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Handgun._Flash_d__7.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Handgun._Flash_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700439B RID: 17307
			// (get) Token: 0x0600DB28 RID: 56104 RVA: 0x00345590 File Offset: 0x00343790
			// (set) Token: 0x0600DB29 RID: 56105 RVA: 0x0006A543 File Offset: 0x00068743
			public unsafe Handgun __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Handgun._Flash_d__7.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Handgun>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Handgun._Flash_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700439C RID: 17308
			// (get) Token: 0x0600DB2A RID: 56106 RVA: 0x003455C0 File Offset: 0x003437C0
			// (set) Token: 0x0600DB2B RID: 56107 RVA: 0x0006A562 File Offset: 0x00068762
			public unsafe Vector3 endPoint
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Handgun._Flash_d__7.NativeFieldInfoPtr_endPoint);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Handgun._Flash_d__7.NativeFieldInfoPtr_endPoint)) = value;
				}
			}

			// Token: 0x04009374 RID: 37748
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009375 RID: 37749
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009376 RID: 37750
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009377 RID: 37751
			private static readonly System.IntPtr NativeFieldInfoPtr_endPoint;

			// Token: 0x04009378 RID: 37752
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009379 RID: 37753
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400937A RID: 37754
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400937B RID: 37755
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400937C RID: 37756
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400937D RID: 37757
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
