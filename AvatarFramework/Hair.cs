using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework
{
	// Token: 0x0200061E RID: 1566
	public class Hair : Accessory
	{
		// Token: 0x06008925 RID: 35109 RVA: 0x00245F58 File Offset: 0x00244158
		// Note: this type is marked as 'beforefieldinit'.
		static Hair()
		{
			Il2CppClassPointerStore<Hair>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework", "Hair");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Hair>.NativeClassPtr);
			Hair.NativeFieldInfoPtr__BlockedByHat_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hair>.NativeClassPtr, "<BlockedByHat>k__BackingField");
			Hair.NativeFieldInfoPtr_hairToHide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hair>.NativeClassPtr, "hairToHide");
			Hair.NativeMethodInfoPtr_get_BlockedByHat_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hair>.NativeClassPtr, 100680514);
			Hair.NativeMethodInfoPtr_set_BlockedByHat_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hair>.NativeClassPtr, 100680515);
			Hair.NativeMethodInfoPtr_SetBlockedByHat_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hair>.NativeClassPtr, 100680516);
			Hair.NativeMethodInfoPtr_BlockHair_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hair>.NativeClassPtr, 100680517);
			Hair.NativeMethodInfoPtr_UnBlockHair_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hair>.NativeClassPtr, 100680518);
			Hair.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hair>.NativeClassPtr, 100680519);
		}

		// Token: 0x1700297A RID: 10618
		// (get) Token: 0x06008926 RID: 35110 RVA: 0x00246028 File Offset: 0x00244228
		// (set) Token: 0x06008927 RID: 35111 RVA: 0x00246064 File Offset: 0x00244264
		public unsafe bool BlockedByHat
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Hair.NativeMethodInfoPtr_get_BlockedByHat_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hair.NativeMethodInfoPtr_set_BlockedByHat_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06008928 RID: 35112 RVA: 0x002460A4 File Offset: 0x002442A4
		[CallerCount(0)]
		public unsafe void SetBlockedByHat(bool blocked)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref blocked;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hair.NativeMethodInfoPtr_SetBlockedByHat_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008929 RID: 35113 RVA: 0x002460E4 File Offset: 0x002442E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255086, XrefRangeEnd = 255088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void BlockHair()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hair.NativeMethodInfoPtr_BlockHair_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600892A RID: 35114 RVA: 0x00246120 File Offset: 0x00244320
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255088, XrefRangeEnd = 255090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UnBlockHair()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hair.NativeMethodInfoPtr_UnBlockHair_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600892B RID: 35115 RVA: 0x0024615C File Offset: 0x0024435C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 253040, RefRangeEnd = 253041, XrefRangeStart = 253040, XrefRangeEnd = 253041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Hair() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Hair>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hair.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600892C RID: 35116 RVA: 0x00040FAB File Offset: 0x0003F1AB
		public Hair(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002978 RID: 10616
		// (get) Token: 0x0600892D RID: 35117 RVA: 0x00246198 File Offset: 0x00244398
		// (set) Token: 0x0600892E RID: 35118 RVA: 0x00040FB4 File Offset: 0x0003F1B4
		public unsafe bool _BlockedByHat_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hair.NativeFieldInfoPtr__BlockedByHat_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hair.NativeFieldInfoPtr__BlockedByHat_k__BackingField)) = value;
			}
		}

		// Token: 0x17002979 RID: 10617
		// (get) Token: 0x0600892F RID: 35119 RVA: 0x002461C0 File Offset: 0x002443C0
		// (set) Token: 0x06008930 RID: 35120 RVA: 0x00040FCF File Offset: 0x0003F1CF
		public unsafe Il2CppReferenceArray<GameObject> hairToHide
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hair.NativeFieldInfoPtr_hairToHide);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hair.NativeFieldInfoPtr_hairToHide), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005D5B RID: 23899
		private static readonly IntPtr NativeFieldInfoPtr__BlockedByHat_k__BackingField;

		// Token: 0x04005D5C RID: 23900
		private static readonly IntPtr NativeFieldInfoPtr_hairToHide;

		// Token: 0x04005D5D RID: 23901
		private static readonly IntPtr NativeMethodInfoPtr_get_BlockedByHat_Public_get_Boolean_0;

		// Token: 0x04005D5E RID: 23902
		private static readonly IntPtr NativeMethodInfoPtr_set_BlockedByHat_Protected_set_Void_Boolean_0;

		// Token: 0x04005D5F RID: 23903
		private static readonly IntPtr NativeMethodInfoPtr_SetBlockedByHat_Public_Void_Boolean_0;

		// Token: 0x04005D60 RID: 23904
		private static readonly IntPtr NativeMethodInfoPtr_BlockHair_Protected_Virtual_New_Void_0;

		// Token: 0x04005D61 RID: 23905
		private static readonly IntPtr NativeMethodInfoPtr_UnBlockHair_Protected_Virtual_New_Void_0;

		// Token: 0x04005D62 RID: 23906
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
