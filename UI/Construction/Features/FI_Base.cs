using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Construction.Features;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.UI.Construction.Features
{
	// Token: 0x0200074D RID: 1869
	public class FI_Base : MonoBehaviour
	{
		// Token: 0x0600A7B3 RID: 42931 RVA: 0x002A1CD4 File Offset: 0x0029FED4
		// Note: this type is marked as 'beforefieldinit'.
		static FI_Base()
		{
			Il2CppClassPointerStore<FI_Base>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Construction.Features", "FI_Base");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FI_Base>.NativeClassPtr);
			FI_Base.NativeFieldInfoPtr_feature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FI_Base>.NativeClassPtr, "feature");
			FI_Base.NativeFieldInfoPtr_onClose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FI_Base>.NativeClassPtr, "onClose");
			FI_Base.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_Feature_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FI_Base>.NativeClassPtr, 100683887);
			FI_Base.NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FI_Base>.NativeClassPtr, 100683888);
			FI_Base.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FI_Base>.NativeClassPtr, 100683889);
		}

		// Token: 0x0600A7B4 RID: 42932 RVA: 0x002A1D68 File Offset: 0x0029FF68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Initialize(Feature _feature)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_feature);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FI_Base.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_Feature_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A7B5 RID: 42933 RVA: 0x002A1DB8 File Offset: 0x0029FFB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292959, XrefRangeEnd = 292965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FI_Base.NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A7B6 RID: 42934 RVA: 0x002A1DF4 File Offset: 0x0029FFF4
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FI_Base() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FI_Base>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FI_Base.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A7B7 RID: 42935 RVA: 0x000527C7 File Offset: 0x000509C7
		public FI_Base(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700338C RID: 13196
		// (get) Token: 0x0600A7B8 RID: 42936 RVA: 0x002A1E30 File Offset: 0x002A0030
		// (set) Token: 0x0600A7B9 RID: 42937 RVA: 0x000527D0 File Offset: 0x000509D0
		public unsafe Feature feature
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_Base.NativeFieldInfoPtr_feature);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Feature>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_Base.NativeFieldInfoPtr_feature), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700338D RID: 13197
		// (get) Token: 0x0600A7BA RID: 42938 RVA: 0x002A1E60 File Offset: 0x002A0060
		// (set) Token: 0x0600A7BB RID: 42939 RVA: 0x000527EF File Offset: 0x000509EF
		public unsafe UnityEvent onClose
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_Base.NativeFieldInfoPtr_onClose);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FI_Base.NativeFieldInfoPtr_onClose), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400706E RID: 28782
		private static readonly IntPtr NativeFieldInfoPtr_feature;

		// Token: 0x0400706F RID: 28783
		private static readonly IntPtr NativeFieldInfoPtr_onClose;

		// Token: 0x04007070 RID: 28784
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_Feature_0;

		// Token: 0x04007071 RID: 28785
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0;

		// Token: 0x04007072 RID: 28786
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
