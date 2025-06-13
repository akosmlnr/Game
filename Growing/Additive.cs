using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Growing
{
	// Token: 0x0200057A RID: 1402
	public class Additive : MonoBehaviour
	{
		// Token: 0x06007A5F RID: 31327 RVA: 0x002134F8 File Offset: 0x002116F8
		// Note: this type is marked as 'beforefieldinit'.
		static Additive()
		{
			Il2CppClassPointerStore<Additive>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Growing", "Additive");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Additive>.NativeClassPtr);
			Additive.NativeFieldInfoPtr_AdditiveName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Additive>.NativeClassPtr, "AdditiveName");
			Additive.NativeFieldInfoPtr_AssetPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Additive>.NativeClassPtr, "AssetPath");
			Additive.NativeFieldInfoPtr_QualityChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Additive>.NativeClassPtr, "QualityChange");
			Additive.NativeFieldInfoPtr_YieldChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Additive>.NativeClassPtr, "YieldChange");
			Additive.NativeFieldInfoPtr_GrowSpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Additive>.NativeClassPtr, "GrowSpeedMultiplier");
			Additive.NativeFieldInfoPtr_InstantGrowth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Additive>.NativeClassPtr, "InstantGrowth");
			Additive.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Additive>.NativeClassPtr, 100678760);
		}

		// Token: 0x06007A60 RID: 31328 RVA: 0x002135B4 File Offset: 0x002117B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236120, XrefRangeEnd = 236125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Additive() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Additive>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Additive.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007A61 RID: 31329 RVA: 0x00039C93 File Offset: 0x00037E93
		public Additive(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170024CA RID: 9418
		// (get) Token: 0x06007A62 RID: 31330 RVA: 0x002135F0 File Offset: 0x002117F0
		// (set) Token: 0x06007A63 RID: 31331 RVA: 0x00039C9C File Offset: 0x00037E9C
		public unsafe string AdditiveName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Additive.NativeFieldInfoPtr_AdditiveName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Additive.NativeFieldInfoPtr_AdditiveName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170024CB RID: 9419
		// (get) Token: 0x06007A64 RID: 31332 RVA: 0x00213618 File Offset: 0x00211818
		// (set) Token: 0x06007A65 RID: 31333 RVA: 0x00039CBB File Offset: 0x00037EBB
		public unsafe string AssetPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Additive.NativeFieldInfoPtr_AssetPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Additive.NativeFieldInfoPtr_AssetPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170024CC RID: 9420
		// (get) Token: 0x06007A66 RID: 31334 RVA: 0x00213640 File Offset: 0x00211840
		// (set) Token: 0x06007A67 RID: 31335 RVA: 0x00039CDA File Offset: 0x00037EDA
		public unsafe float QualityChange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Additive.NativeFieldInfoPtr_QualityChange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Additive.NativeFieldInfoPtr_QualityChange)) = value;
			}
		}

		// Token: 0x170024CD RID: 9421
		// (get) Token: 0x06007A68 RID: 31336 RVA: 0x00213668 File Offset: 0x00211868
		// (set) Token: 0x06007A69 RID: 31337 RVA: 0x00039CF5 File Offset: 0x00037EF5
		public unsafe float YieldChange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Additive.NativeFieldInfoPtr_YieldChange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Additive.NativeFieldInfoPtr_YieldChange)) = value;
			}
		}

		// Token: 0x170024CE RID: 9422
		// (get) Token: 0x06007A6A RID: 31338 RVA: 0x00213690 File Offset: 0x00211890
		// (set) Token: 0x06007A6B RID: 31339 RVA: 0x00039D10 File Offset: 0x00037F10
		public unsafe float GrowSpeedMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Additive.NativeFieldInfoPtr_GrowSpeedMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Additive.NativeFieldInfoPtr_GrowSpeedMultiplier)) = value;
			}
		}

		// Token: 0x170024CF RID: 9423
		// (get) Token: 0x06007A6C RID: 31340 RVA: 0x002136B8 File Offset: 0x002118B8
		// (set) Token: 0x06007A6D RID: 31341 RVA: 0x00039D2B File Offset: 0x00037F2B
		public unsafe float InstantGrowth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Additive.NativeFieldInfoPtr_InstantGrowth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Additive.NativeFieldInfoPtr_InstantGrowth)) = value;
			}
		}

		// Token: 0x04005369 RID: 21353
		private static readonly IntPtr NativeFieldInfoPtr_AdditiveName;

		// Token: 0x0400536A RID: 21354
		private static readonly IntPtr NativeFieldInfoPtr_AssetPath;

		// Token: 0x0400536B RID: 21355
		private static readonly IntPtr NativeFieldInfoPtr_QualityChange;

		// Token: 0x0400536C RID: 21356
		private static readonly IntPtr NativeFieldInfoPtr_YieldChange;

		// Token: 0x0400536D RID: 21357
		private static readonly IntPtr NativeFieldInfoPtr_GrowSpeedMultiplier;

		// Token: 0x0400536E RID: 21358
		private static readonly IntPtr NativeFieldInfoPtr_InstantGrowth;

		// Token: 0x0400536F RID: 21359
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
