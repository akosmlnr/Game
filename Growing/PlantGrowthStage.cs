using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Growing
{
	// Token: 0x0200057D RID: 1405
	public class PlantGrowthStage : MonoBehaviour
	{
		// Token: 0x06007AAD RID: 31405 RVA: 0x002143A4 File Offset: 0x002125A4
		// Note: this type is marked as 'beforefieldinit'.
		static PlantGrowthStage()
		{
			Il2CppClassPointerStore<PlantGrowthStage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Growing", "PlantGrowthStage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlantGrowthStage>.NativeClassPtr);
			PlantGrowthStage.NativeFieldInfoPtr_GrowthSites = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlantGrowthStage>.NativeClassPtr, "GrowthSites");
			PlantGrowthStage.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlantGrowthStage>.NativeClassPtr, 100678782);
		}

		// Token: 0x06007AAE RID: 31406 RVA: 0x002143FC File Offset: 0x002125FC
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlantGrowthStage() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlantGrowthStage>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlantGrowthStage.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007AAF RID: 31407 RVA: 0x00039F8D File Offset: 0x0003818D
		public PlantGrowthStage(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170024E7 RID: 9447
		// (get) Token: 0x06007AB0 RID: 31408 RVA: 0x00214438 File Offset: 0x00212638
		// (set) Token: 0x06007AB1 RID: 31409 RVA: 0x00039F96 File Offset: 0x00038196
		public unsafe Il2CppReferenceArray<Transform> GrowthSites
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlantGrowthStage.NativeFieldInfoPtr_GrowthSites);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlantGrowthStage.NativeFieldInfoPtr_GrowthSites), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005398 RID: 21400
		private static readonly IntPtr NativeFieldInfoPtr_GrowthSites;

		// Token: 0x04005399 RID: 21401
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
