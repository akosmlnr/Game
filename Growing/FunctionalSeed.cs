using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.PlayerTasks;
using Il2CppScheduleOne.Trash;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Growing
{
	// Token: 0x02000578 RID: 1400
	public class FunctionalSeed : MonoBehaviour
	{
		// Token: 0x06007A40 RID: 31296 RVA: 0x00212FB4 File Offset: 0x002111B4
		// Note: this type is marked as 'beforefieldinit'.
		static FunctionalSeed()
		{
			Il2CppClassPointerStore<FunctionalSeed>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Growing", "FunctionalSeed");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FunctionalSeed>.NativeClassPtr);
			FunctionalSeed.NativeFieldInfoPtr_onSeedExitVial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalSeed>.NativeClassPtr, "onSeedExitVial");
			FunctionalSeed.NativeFieldInfoPtr_Vial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalSeed>.NativeClassPtr, "Vial");
			FunctionalSeed.NativeFieldInfoPtr_SeedBlocker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalSeed>.NativeClassPtr, "SeedBlocker");
			FunctionalSeed.NativeFieldInfoPtr_Cap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalSeed>.NativeClassPtr, "Cap");
			FunctionalSeed.NativeFieldInfoPtr_SeedCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalSeed>.NativeClassPtr, "SeedCollider");
			FunctionalSeed.NativeFieldInfoPtr_SeedRigidbody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalSeed>.NativeClassPtr, "SeedRigidbody");
			FunctionalSeed.NativeFieldInfoPtr_TrashPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalSeed>.NativeClassPtr, "TrashPrefab");
			FunctionalSeed.NativeMethodInfoPtr_TriggerExit_Public_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalSeed>.NativeClassPtr, 100678753);
			FunctionalSeed.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalSeed>.NativeClassPtr, 100678754);
		}

		// Token: 0x06007A41 RID: 31297 RVA: 0x00213098 File Offset: 0x00211298
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236086, XrefRangeEnd = 236090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TriggerExit(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionalSeed.NativeMethodInfoPtr_TriggerExit_Public_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007A42 RID: 31298 RVA: 0x002130DC File Offset: 0x002112DC
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FunctionalSeed() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FunctionalSeed>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionalSeed.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007A43 RID: 31299 RVA: 0x00039B4F File Offset: 0x00037D4F
		public FunctionalSeed(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170024BF RID: 9407
		// (get) Token: 0x06007A44 RID: 31300 RVA: 0x00213118 File Offset: 0x00211318
		// (set) Token: 0x06007A45 RID: 31301 RVA: 0x00039B58 File Offset: 0x00037D58
		public unsafe Il2CppSystem.Action onSeedExitVial
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalSeed.NativeFieldInfoPtr_onSeedExitVial);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalSeed.NativeFieldInfoPtr_onSeedExitVial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024C0 RID: 9408
		// (get) Token: 0x06007A46 RID: 31302 RVA: 0x00213148 File Offset: 0x00211348
		// (set) Token: 0x06007A47 RID: 31303 RVA: 0x00039B77 File Offset: 0x00037D77
		public unsafe Draggable Vial
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalSeed.NativeFieldInfoPtr_Vial);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Draggable>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalSeed.NativeFieldInfoPtr_Vial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024C1 RID: 9409
		// (get) Token: 0x06007A48 RID: 31304 RVA: 0x00213178 File Offset: 0x00211378
		// (set) Token: 0x06007A49 RID: 31305 RVA: 0x00039B96 File Offset: 0x00037D96
		public unsafe Collider SeedBlocker
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalSeed.NativeFieldInfoPtr_SeedBlocker);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalSeed.NativeFieldInfoPtr_SeedBlocker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024C2 RID: 9410
		// (get) Token: 0x06007A4A RID: 31306 RVA: 0x002131A8 File Offset: 0x002113A8
		// (set) Token: 0x06007A4B RID: 31307 RVA: 0x00039BB5 File Offset: 0x00037DB5
		public unsafe VialCap Cap
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalSeed.NativeFieldInfoPtr_Cap);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VialCap>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalSeed.NativeFieldInfoPtr_Cap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024C3 RID: 9411
		// (get) Token: 0x06007A4C RID: 31308 RVA: 0x002131D8 File Offset: 0x002113D8
		// (set) Token: 0x06007A4D RID: 31309 RVA: 0x00039BD4 File Offset: 0x00037DD4
		public unsafe Collider SeedCollider
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalSeed.NativeFieldInfoPtr_SeedCollider);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalSeed.NativeFieldInfoPtr_SeedCollider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024C4 RID: 9412
		// (get) Token: 0x06007A4E RID: 31310 RVA: 0x00213208 File Offset: 0x00211408
		// (set) Token: 0x06007A4F RID: 31311 RVA: 0x00039BF3 File Offset: 0x00037DF3
		public unsafe Rigidbody SeedRigidbody
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalSeed.NativeFieldInfoPtr_SeedRigidbody);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalSeed.NativeFieldInfoPtr_SeedRigidbody), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024C5 RID: 9413
		// (get) Token: 0x06007A50 RID: 31312 RVA: 0x00213238 File Offset: 0x00211438
		// (set) Token: 0x06007A51 RID: 31313 RVA: 0x00039C12 File Offset: 0x00037E12
		public unsafe TrashItem TrashPrefab
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalSeed.NativeFieldInfoPtr_TrashPrefab);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrashItem>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalSeed.NativeFieldInfoPtr_TrashPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005358 RID: 21336
		private static readonly System.IntPtr NativeFieldInfoPtr_onSeedExitVial;

		// Token: 0x04005359 RID: 21337
		private static readonly System.IntPtr NativeFieldInfoPtr_Vial;

		// Token: 0x0400535A RID: 21338
		private static readonly System.IntPtr NativeFieldInfoPtr_SeedBlocker;

		// Token: 0x0400535B RID: 21339
		private static readonly System.IntPtr NativeFieldInfoPtr_Cap;

		// Token: 0x0400535C RID: 21340
		private static readonly System.IntPtr NativeFieldInfoPtr_SeedCollider;

		// Token: 0x0400535D RID: 21341
		private static readonly System.IntPtr NativeFieldInfoPtr_SeedRigidbody;

		// Token: 0x0400535E RID: 21342
		private static readonly System.IntPtr NativeFieldInfoPtr_TrashPrefab;

		// Token: 0x0400535F RID: 21343
		private static readonly System.IntPtr NativeMethodInfoPtr_TriggerExit_Public_Void_Collider_0;

		// Token: 0x04005360 RID: 21344
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
