using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts.HandheldBin
{
	// Token: 0x0200078B RID: 1931
	public class HandheldBin_Functional : MonoBehaviour
	{
		// Token: 0x0600B76A RID: 46954 RVA: 0x002DE600 File Offset: 0x002DC800
		// Note: this type is marked as 'beforefieldinit'.
		static HandheldBin_Functional()
		{
			Il2CppClassPointerStore<HandheldBin_Functional>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts.HandheldBin", "HandheldBin_Functional");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HandheldBin_Functional>.NativeClassPtr);
			HandheldBin_Functional.NativeFieldInfoPtr_trash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandheldBin_Functional>.NativeClassPtr, "trash");
			HandheldBin_Functional.NativeFieldInfoPtr_trash_MinY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandheldBin_Functional>.NativeClassPtr, "trash_MinY");
			HandheldBin_Functional.NativeFieldInfoPtr_trash_MaxY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandheldBin_Functional>.NativeClassPtr, "trash_MaxY");
			HandheldBin_Functional.NativeFieldInfoPtr__fillLevel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandheldBin_Functional>.NativeClassPtr, "<fillLevel>k__BackingField");
			HandheldBin_Functional.NativeMethodInfoPtr_get_fillLevel_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandheldBin_Functional>.NativeClassPtr, 100686063);
			HandheldBin_Functional.NativeMethodInfoPtr_set_fillLevel_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandheldBin_Functional>.NativeClassPtr, 100686064);
			HandheldBin_Functional.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandheldBin_Functional>.NativeClassPtr, 100686065);
			HandheldBin_Functional.NativeMethodInfoPtr_SetAmount_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandheldBin_Functional>.NativeClassPtr, 100686066);
			HandheldBin_Functional.NativeMethodInfoPtr_UpdateTrashVisuals_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandheldBin_Functional>.NativeClassPtr, 100686067);
			HandheldBin_Functional.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandheldBin_Functional>.NativeClassPtr, 100686068);
		}

		// Token: 0x17003895 RID: 14485
		// (get) Token: 0x0600B76B RID: 46955 RVA: 0x002DE6F8 File Offset: 0x002DC8F8
		// (set) Token: 0x0600B76C RID: 46956 RVA: 0x002DE734 File Offset: 0x002DC934
		public unsafe float fillLevel
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 31486, RefRangeEnd = 31487, XrefRangeStart = 31486, XrefRangeEnd = 31487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(HandheldBin_Functional.NativeMethodInfoPtr_get_fillLevel_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 31487, RefRangeEnd = 31489, XrefRangeStart = 31487, XrefRangeEnd = 31489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandheldBin_Functional.NativeMethodInfoPtr_set_fillLevel_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x0600B76D RID: 46957 RVA: 0x002DE774 File Offset: 0x002DC974
		[CallerCount(0)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HandheldBin_Functional.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B76E RID: 46958 RVA: 0x002DE7B0 File Offset: 0x002DC9B0
		[CallerCount(0)]
		public unsafe void SetAmount(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandheldBin_Functional.NativeMethodInfoPtr_SetAmount_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B76F RID: 46959 RVA: 0x002DE7F0 File Offset: 0x002DC9F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314837, XrefRangeEnd = 314840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateTrashVisuals()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HandheldBin_Functional.NativeMethodInfoPtr_UpdateTrashVisuals_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B770 RID: 46960 RVA: 0x002DE82C File Offset: 0x002DCA2C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HandheldBin_Functional() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HandheldBin_Functional>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandheldBin_Functional.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B771 RID: 46961 RVA: 0x00059823 File Offset: 0x00057A23
		public HandheldBin_Functional(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003891 RID: 14481
		// (get) Token: 0x0600B772 RID: 46962 RVA: 0x002DE868 File Offset: 0x002DCA68
		// (set) Token: 0x0600B773 RID: 46963 RVA: 0x0005982C File Offset: 0x00057A2C
		public unsafe Transform trash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandheldBin_Functional.NativeFieldInfoPtr_trash);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandheldBin_Functional.NativeFieldInfoPtr_trash), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003892 RID: 14482
		// (get) Token: 0x0600B774 RID: 46964 RVA: 0x002DE898 File Offset: 0x002DCA98
		// (set) Token: 0x0600B775 RID: 46965 RVA: 0x0005984B File Offset: 0x00057A4B
		public unsafe float trash_MinY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandheldBin_Functional.NativeFieldInfoPtr_trash_MinY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandheldBin_Functional.NativeFieldInfoPtr_trash_MinY)) = value;
			}
		}

		// Token: 0x17003893 RID: 14483
		// (get) Token: 0x0600B776 RID: 46966 RVA: 0x002DE8C0 File Offset: 0x002DCAC0
		// (set) Token: 0x0600B777 RID: 46967 RVA: 0x00059866 File Offset: 0x00057A66
		public unsafe float trash_MaxY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandheldBin_Functional.NativeFieldInfoPtr_trash_MaxY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandheldBin_Functional.NativeFieldInfoPtr_trash_MaxY)) = value;
			}
		}

		// Token: 0x17003894 RID: 14484
		// (get) Token: 0x0600B778 RID: 46968 RVA: 0x002DE8E8 File Offset: 0x002DCAE8
		// (set) Token: 0x0600B779 RID: 46969 RVA: 0x00059881 File Offset: 0x00057A81
		public unsafe float _fillLevel_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandheldBin_Functional.NativeFieldInfoPtr__fillLevel_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandheldBin_Functional.NativeFieldInfoPtr__fillLevel_k__BackingField)) = value;
			}
		}

		// Token: 0x04007BDD RID: 31709
		private static readonly IntPtr NativeFieldInfoPtr_trash;

		// Token: 0x04007BDE RID: 31710
		private static readonly IntPtr NativeFieldInfoPtr_trash_MinY;

		// Token: 0x04007BDF RID: 31711
		private static readonly IntPtr NativeFieldInfoPtr_trash_MaxY;

		// Token: 0x04007BE0 RID: 31712
		private static readonly IntPtr NativeFieldInfoPtr__fillLevel_k__BackingField;

		// Token: 0x04007BE1 RID: 31713
		private static readonly IntPtr NativeMethodInfoPtr_get_fillLevel_Public_get_Single_0;

		// Token: 0x04007BE2 RID: 31714
		private static readonly IntPtr NativeMethodInfoPtr_set_fillLevel_Protected_set_Void_Single_0;

		// Token: 0x04007BE3 RID: 31715
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04007BE4 RID: 31716
		private static readonly IntPtr NativeMethodInfoPtr_SetAmount_Public_Void_Single_0;

		// Token: 0x04007BE5 RID: 31717
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTrashVisuals_Protected_Virtual_New_Void_0;

		// Token: 0x04007BE6 RID: 31718
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
