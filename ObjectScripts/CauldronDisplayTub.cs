using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x02000769 RID: 1897
	public class CauldronDisplayTub : MonoBehaviour
	{
		// Token: 0x0600AEBB RID: 44731 RVA: 0x002BBFF0 File Offset: 0x002BA1F0
		// Note: this type is marked as 'beforefieldinit'.
		static CauldronDisplayTub()
		{
			Il2CppClassPointerStore<CauldronDisplayTub>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "CauldronDisplayTub");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CauldronDisplayTub>.NativeClassPtr);
			CauldronDisplayTub.NativeFieldInfoPtr_CocaLeafContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CauldronDisplayTub>.NativeClassPtr, "CocaLeafContainer");
			CauldronDisplayTub.NativeFieldInfoPtr_Container_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CauldronDisplayTub>.NativeClassPtr, "Container_Min");
			CauldronDisplayTub.NativeFieldInfoPtr_Container_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CauldronDisplayTub>.NativeClassPtr, "Container_Max");
			CauldronDisplayTub.NativeMethodInfoPtr_Configure_Public_Void_EContents_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronDisplayTub>.NativeClassPtr, 100684875);
			CauldronDisplayTub.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronDisplayTub>.NativeClassPtr, 100684876);
		}

		// Token: 0x0600AEBC RID: 44732 RVA: 0x002BC084 File Offset: 0x002BA284
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 302885, RefRangeEnd = 302887, XrefRangeStart = 302872, XrefRangeEnd = 302885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Configure(CauldronDisplayTub.EContents contentsType, float fillLevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref contentsType;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fillLevel;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CauldronDisplayTub.NativeMethodInfoPtr_Configure_Public_Void_EContents_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AEBD RID: 44733 RVA: 0x002BC0D0 File Offset: 0x002BA2D0
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CauldronDisplayTub() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CauldronDisplayTub>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CauldronDisplayTub.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AEBE RID: 44734 RVA: 0x00055ABC File Offset: 0x00053CBC
		public CauldronDisplayTub(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170035D1 RID: 13777
		// (get) Token: 0x0600AEBF RID: 44735 RVA: 0x002BC10C File Offset: 0x002BA30C
		// (set) Token: 0x0600AEC0 RID: 44736 RVA: 0x00055AC5 File Offset: 0x00053CC5
		public unsafe Transform CocaLeafContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronDisplayTub.NativeFieldInfoPtr_CocaLeafContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronDisplayTub.NativeFieldInfoPtr_CocaLeafContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035D2 RID: 13778
		// (get) Token: 0x0600AEC1 RID: 44737 RVA: 0x002BC13C File Offset: 0x002BA33C
		// (set) Token: 0x0600AEC2 RID: 44738 RVA: 0x00055AE4 File Offset: 0x00053CE4
		public unsafe Transform Container_Min
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronDisplayTub.NativeFieldInfoPtr_Container_Min);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronDisplayTub.NativeFieldInfoPtr_Container_Min), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035D3 RID: 13779
		// (get) Token: 0x0600AEC3 RID: 44739 RVA: 0x002BC16C File Offset: 0x002BA36C
		// (set) Token: 0x0600AEC4 RID: 44740 RVA: 0x00055B03 File Offset: 0x00053D03
		public unsafe Transform Container_Max
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronDisplayTub.NativeFieldInfoPtr_Container_Max);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronDisplayTub.NativeFieldInfoPtr_Container_Max), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400757D RID: 30077
		private static readonly IntPtr NativeFieldInfoPtr_CocaLeafContainer;

		// Token: 0x0400757E RID: 30078
		private static readonly IntPtr NativeFieldInfoPtr_Container_Min;

		// Token: 0x0400757F RID: 30079
		private static readonly IntPtr NativeFieldInfoPtr_Container_Max;

		// Token: 0x04007580 RID: 30080
		private static readonly IntPtr NativeMethodInfoPtr_Configure_Public_Void_EContents_Single_0;

		// Token: 0x04007581 RID: 30081
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000C41 RID: 3137
		[OriginalName("Assembly-CSharp.dll", "", "EContents")]
		public enum EContents
		{
			// Token: 0x0400992D RID: 39213
			None,
			// Token: 0x0400992E RID: 39214
			CocaLeaf
		}
	}
}
