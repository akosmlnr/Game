using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework.Equipping
{
	// Token: 0x02000628 RID: 1576
	public class Taser : AvatarRangedWeapon
	{
		// Token: 0x060089FC RID: 35324 RVA: 0x00248578 File Offset: 0x00246778
		// Note: this type is marked as 'beforefieldinit'.
		static Taser()
		{
			Il2CppClassPointerStore<Taser>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Equipping", "Taser");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Taser>.NativeClassPtr);
			Taser.NativeFieldInfoPtr_TaseDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Taser>.NativeClassPtr, "TaseDuration");
			Taser.NativeFieldInfoPtr_TaseMoveSpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Taser>.NativeClassPtr, "TaseMoveSpeedMultiplier");
			Taser.NativeFieldInfoPtr_FlashObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Taser>.NativeClassPtr, "FlashObject");
			Taser.NativeFieldInfoPtr_ChargeSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Taser>.NativeClassPtr, "ChargeSound");
			Taser.NativeFieldInfoPtr_RayPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Taser>.NativeClassPtr, "RayPrefab");
			Taser.NativeFieldInfoPtr_flashRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Taser>.NativeClassPtr, "flashRoutine");
			Taser.NativeMethodInfoPtr_Equip_Public_Virtual_Void_Avatar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Taser>.NativeClassPtr, 100680604);
			Taser.NativeMethodInfoPtr_Shoot_Public_Virtual_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Taser>.NativeClassPtr, 100680605);
			Taser.NativeMethodInfoPtr_SetIsRaised_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Taser>.NativeClassPtr, 100680606);
			Taser.NativeMethodInfoPtr_Flash_Private_IEnumerator_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Taser>.NativeClassPtr, 100680607);
			Taser.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Taser>.NativeClassPtr, 100680608);
		}

		// Token: 0x060089FD RID: 35325 RVA: 0x00248684 File Offset: 0x00246884
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255747, XrefRangeEnd = 255758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Equip(Avatar _avatar)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_avatar);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Taser.NativeMethodInfoPtr_Equip_Public_Virtual_Void_Avatar_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060089FE RID: 35326 RVA: 0x002486D4 File Offset: 0x002468D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255758, XrefRangeEnd = 255769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Shoot(Vector3 endPoint)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref endPoint;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Taser.NativeMethodInfoPtr_Shoot_Public_Virtual_Void_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060089FF RID: 35327 RVA: 0x00248720 File Offset: 0x00246920
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255769, XrefRangeEnd = 255775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetIsRaised(bool raised)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref raised;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Taser.NativeMethodInfoPtr_SetIsRaised_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008A00 RID: 35328 RVA: 0x0024876C File Offset: 0x0024696C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255775, XrefRangeEnd = 255780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Flash(Vector3 endPoint)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref endPoint;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Taser.NativeMethodInfoPtr_Flash_Private_IEnumerator_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x06008A01 RID: 35329 RVA: 0x002487B8 File Offset: 0x002469B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255780, XrefRangeEnd = 255784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Taser() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Taser>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Taser.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008A02 RID: 35330 RVA: 0x000417AF File Offset: 0x0003F9AF
		public Taser(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170029C1 RID: 10689
		// (get) Token: 0x06008A03 RID: 35331 RVA: 0x002487F4 File Offset: 0x002469F4
		// (set) Token: 0x06008A04 RID: 35332 RVA: 0x000417B8 File Offset: 0x0003F9B8
		public unsafe static float TaseDuration
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Taser.NativeFieldInfoPtr_TaseDuration, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Taser.NativeFieldInfoPtr_TaseDuration, (void*)(&value));
			}
		}

		// Token: 0x170029C2 RID: 10690
		// (get) Token: 0x06008A05 RID: 35333 RVA: 0x00248810 File Offset: 0x00246A10
		// (set) Token: 0x06008A06 RID: 35334 RVA: 0x000417C6 File Offset: 0x0003F9C6
		public unsafe static float TaseMoveSpeedMultiplier
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Taser.NativeFieldInfoPtr_TaseMoveSpeedMultiplier, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Taser.NativeFieldInfoPtr_TaseMoveSpeedMultiplier, (void*)(&value));
			}
		}

		// Token: 0x170029C3 RID: 10691
		// (get) Token: 0x06008A07 RID: 35335 RVA: 0x0024882C File Offset: 0x00246A2C
		// (set) Token: 0x06008A08 RID: 35336 RVA: 0x000417D4 File Offset: 0x0003F9D4
		public unsafe GameObject FlashObject
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Taser.NativeFieldInfoPtr_FlashObject);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Taser.NativeFieldInfoPtr_FlashObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170029C4 RID: 10692
		// (get) Token: 0x06008A09 RID: 35337 RVA: 0x0024885C File Offset: 0x00246A5C
		// (set) Token: 0x06008A0A RID: 35338 RVA: 0x000417F3 File Offset: 0x0003F9F3
		public unsafe AudioSourceController ChargeSound
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Taser.NativeFieldInfoPtr_ChargeSound);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Taser.NativeFieldInfoPtr_ChargeSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170029C5 RID: 10693
		// (get) Token: 0x06008A0B RID: 35339 RVA: 0x0024888C File Offset: 0x00246A8C
		// (set) Token: 0x06008A0C RID: 35340 RVA: 0x00041812 File Offset: 0x0003FA12
		public unsafe GameObject RayPrefab
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Taser.NativeFieldInfoPtr_RayPrefab);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Taser.NativeFieldInfoPtr_RayPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170029C6 RID: 10694
		// (get) Token: 0x06008A0D RID: 35341 RVA: 0x002488BC File Offset: 0x00246ABC
		// (set) Token: 0x06008A0E RID: 35342 RVA: 0x00041831 File Offset: 0x0003FA31
		public unsafe Coroutine flashRoutine
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Taser.NativeFieldInfoPtr_flashRoutine);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Taser.NativeFieldInfoPtr_flashRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005DDA RID: 24026
		private static readonly System.IntPtr NativeFieldInfoPtr_TaseDuration;

		// Token: 0x04005DDB RID: 24027
		private static readonly System.IntPtr NativeFieldInfoPtr_TaseMoveSpeedMultiplier;

		// Token: 0x04005DDC RID: 24028
		private static readonly System.IntPtr NativeFieldInfoPtr_FlashObject;

		// Token: 0x04005DDD RID: 24029
		private static readonly System.IntPtr NativeFieldInfoPtr_ChargeSound;

		// Token: 0x04005DDE RID: 24030
		private static readonly System.IntPtr NativeFieldInfoPtr_RayPrefab;

		// Token: 0x04005DDF RID: 24031
		private static readonly System.IntPtr NativeFieldInfoPtr_flashRoutine;

		// Token: 0x04005DE0 RID: 24032
		private static readonly System.IntPtr NativeMethodInfoPtr_Equip_Public_Virtual_Void_Avatar_0;

		// Token: 0x04005DE1 RID: 24033
		private static readonly System.IntPtr NativeMethodInfoPtr_Shoot_Public_Virtual_Void_Vector3_0;

		// Token: 0x04005DE2 RID: 24034
		private static readonly System.IntPtr NativeMethodInfoPtr_SetIsRaised_Public_Virtual_Void_Boolean_0;

		// Token: 0x04005DE3 RID: 24035
		private static readonly System.IntPtr NativeMethodInfoPtr_Flash_Private_IEnumerator_Vector3_0;

		// Token: 0x04005DE4 RID: 24036
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B49 RID: 2889
		[ObfuscatedName("ScheduleOne.AvatarFramework.Equipping.Taser+<Flash>d__9")]
		public sealed class _Flash_d__9 : Il2CppSystem.Object
		{
			// Token: 0x0600DB2C RID: 56108 RVA: 0x003455E8 File Offset: 0x003437E8
			// Note: this type is marked as 'beforefieldinit'.
			static _Flash_d__9()
			{
				Il2CppClassPointerStore<Taser._Flash_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Taser>.NativeClassPtr, "<Flash>d__9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Taser._Flash_d__9>.NativeClassPtr);
				Taser._Flash_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Taser._Flash_d__9>.NativeClassPtr, "<>1__state");
				Taser._Flash_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Taser._Flash_d__9>.NativeClassPtr, "<>2__current");
				Taser._Flash_d__9.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Taser._Flash_d__9>.NativeClassPtr, "<>4__this");
				Taser._Flash_d__9.NativeFieldInfoPtr_endPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Taser._Flash_d__9>.NativeClassPtr, "endPoint");
				Taser._Flash_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Taser._Flash_d__9>.NativeClassPtr, 100680609);
				Taser._Flash_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Taser._Flash_d__9>.NativeClassPtr, 100680610);
				Taser._Flash_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Taser._Flash_d__9>.NativeClassPtr, 100680611);
				Taser._Flash_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Taser._Flash_d__9>.NativeClassPtr, 100680612);
				Taser._Flash_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Taser._Flash_d__9>.NativeClassPtr, 100680613);
				Taser._Flash_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Taser._Flash_d__9>.NativeClassPtr, 100680614);
			}

			// Token: 0x0600DB2D RID: 56109 RVA: 0x003456DC File Offset: 0x003438DC
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Flash_d__9(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Taser._Flash_d__9>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Taser._Flash_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DB2E RID: 56110 RVA: 0x00345724 File Offset: 0x00343924
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Taser._Flash_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DB2F RID: 56111 RVA: 0x00345758 File Offset: 0x00343958
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255706, XrefRangeEnd = 255742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Taser._Flash_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x170043A3 RID: 17315
			// (get) Token: 0x0600DB30 RID: 56112 RVA: 0x00345794 File Offset: 0x00343994
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Taser._Flash_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600DB31 RID: 56113 RVA: 0x003457D4 File Offset: 0x003439D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255742, XrefRangeEnd = 255747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Taser._Flash_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x170043A4 RID: 17316
			// (get) Token: 0x0600DB32 RID: 56114 RVA: 0x00345808 File Offset: 0x00343A08
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Taser._Flash_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600DB33 RID: 56115 RVA: 0x0006A57D File Offset: 0x0006877D
			public _Flash_d__9(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700439F RID: 17311
			// (get) Token: 0x0600DB34 RID: 56116 RVA: 0x00345848 File Offset: 0x00343A48
			// (set) Token: 0x0600DB35 RID: 56117 RVA: 0x0006A586 File Offset: 0x00068786
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Taser._Flash_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Taser._Flash_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170043A0 RID: 17312
			// (get) Token: 0x0600DB36 RID: 56118 RVA: 0x00345870 File Offset: 0x00343A70
			// (set) Token: 0x0600DB37 RID: 56119 RVA: 0x0006A5A1 File Offset: 0x000687A1
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Taser._Flash_d__9.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Taser._Flash_d__9.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043A1 RID: 17313
			// (get) Token: 0x0600DB38 RID: 56120 RVA: 0x003458A0 File Offset: 0x00343AA0
			// (set) Token: 0x0600DB39 RID: 56121 RVA: 0x0006A5C0 File Offset: 0x000687C0
			public unsafe Taser __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Taser._Flash_d__9.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Taser>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Taser._Flash_d__9.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043A2 RID: 17314
			// (get) Token: 0x0600DB3A RID: 56122 RVA: 0x003458D0 File Offset: 0x00343AD0
			// (set) Token: 0x0600DB3B RID: 56123 RVA: 0x0006A5DF File Offset: 0x000687DF
			public unsafe Vector3 endPoint
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Taser._Flash_d__9.NativeFieldInfoPtr_endPoint);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Taser._Flash_d__9.NativeFieldInfoPtr_endPoint)) = value;
				}
			}

			// Token: 0x0400937E RID: 37758
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400937F RID: 37759
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009380 RID: 37760
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009381 RID: 37761
			private static readonly System.IntPtr NativeFieldInfoPtr_endPoint;

			// Token: 0x04009382 RID: 37762
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009383 RID: 37763
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009384 RID: 37764
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009385 RID: 37765
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009386 RID: 37766
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009387 RID: 37767
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
