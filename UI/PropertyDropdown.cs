using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Property;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000685 RID: 1669
	public class PropertyDropdown : MonoBehaviour
	{
		// Token: 0x0600940D RID: 37901 RVA: 0x00265E80 File Offset: 0x00264080
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyDropdown()
		{
			Il2CppClassPointerStore<PropertyDropdown>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "PropertyDropdown");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyDropdown>.NativeClassPtr);
			PropertyDropdown.NativeFieldInfoPtr_selectedProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyDropdown>.NativeClassPtr, "selectedProperty");
			PropertyDropdown.NativeFieldInfoPtr_TMP_dropdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyDropdown>.NativeClassPtr, "TMP_dropdown");
			PropertyDropdown.NativeFieldInfoPtr_dropdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyDropdown>.NativeClassPtr, "dropdown");
			PropertyDropdown.NativeFieldInfoPtr_intToProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyDropdown>.NativeClassPtr, "intToProperty");
			PropertyDropdown.NativeFieldInfoPtr_onSelectionChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyDropdown>.NativeClassPtr, "onSelectionChanged");
			PropertyDropdown.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyDropdown>.NativeClassPtr, 100681744);
			PropertyDropdown.NativeMethodInfoPtr_PropertyAcquired_Private_Void_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyDropdown>.NativeClassPtr, 100681745);
			PropertyDropdown.NativeMethodInfoPtr_ValueChanged_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyDropdown>.NativeClassPtr, 100681746);
			PropertyDropdown.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyDropdown>.NativeClassPtr, 100681747);
		}

		// Token: 0x0600940E RID: 37902 RVA: 0x00265F64 File Offset: 0x00264164
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267453, XrefRangeEnd = 267523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyDropdown.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600940F RID: 37903 RVA: 0x00265FA0 File Offset: 0x002641A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267523, XrefRangeEnd = 267552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PropertyAcquired(Property p)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyDropdown.NativeMethodInfoPtr_PropertyAcquired_Private_Void_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009410 RID: 37904 RVA: 0x00265FE4 File Offset: 0x002641E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267552, XrefRangeEnd = 267556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValueChanged(int newVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref newVal;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyDropdown.NativeMethodInfoPtr_ValueChanged_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009411 RID: 37905 RVA: 0x00266024 File Offset: 0x00264224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267556, XrefRangeEnd = 267564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyDropdown() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyDropdown>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyDropdown.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009412 RID: 37906 RVA: 0x0004752C File Offset: 0x0004572C
		public PropertyDropdown(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002D27 RID: 11559
		// (get) Token: 0x06009413 RID: 37907 RVA: 0x00266060 File Offset: 0x00264260
		// (set) Token: 0x06009414 RID: 37908 RVA: 0x00047535 File Offset: 0x00045735
		public unsafe Property selectedProperty
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyDropdown.NativeFieldInfoPtr_selectedProperty);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyDropdown.NativeFieldInfoPtr_selectedProperty), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D28 RID: 11560
		// (get) Token: 0x06009415 RID: 37909 RVA: 0x00266090 File Offset: 0x00264290
		// (set) Token: 0x06009416 RID: 37910 RVA: 0x00047554 File Offset: 0x00045754
		public unsafe TMP_Dropdown TMP_dropdown
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyDropdown.NativeFieldInfoPtr_TMP_dropdown);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Dropdown>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyDropdown.NativeFieldInfoPtr_TMP_dropdown), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D29 RID: 11561
		// (get) Token: 0x06009417 RID: 37911 RVA: 0x002660C0 File Offset: 0x002642C0
		// (set) Token: 0x06009418 RID: 37912 RVA: 0x00047573 File Offset: 0x00045773
		public unsafe Dropdown dropdown
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyDropdown.NativeFieldInfoPtr_dropdown);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dropdown>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyDropdown.NativeFieldInfoPtr_dropdown), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D2A RID: 11562
		// (get) Token: 0x06009419 RID: 37913 RVA: 0x002660F0 File Offset: 0x002642F0
		// (set) Token: 0x0600941A RID: 37914 RVA: 0x00047592 File Offset: 0x00045792
		public unsafe Dictionary<int, Property> intToProperty
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyDropdown.NativeFieldInfoPtr_intToProperty);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Property>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyDropdown.NativeFieldInfoPtr_intToProperty), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D2B RID: 11563
		// (get) Token: 0x0600941B RID: 37915 RVA: 0x00266120 File Offset: 0x00264320
		// (set) Token: 0x0600941C RID: 37916 RVA: 0x000475B1 File Offset: 0x000457B1
		public unsafe Il2CppSystem.Action onSelectionChanged
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyDropdown.NativeFieldInfoPtr_onSelectionChanged);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyDropdown.NativeFieldInfoPtr_onSelectionChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006413 RID: 25619
		private static readonly System.IntPtr NativeFieldInfoPtr_selectedProperty;

		// Token: 0x04006414 RID: 25620
		private static readonly System.IntPtr NativeFieldInfoPtr_TMP_dropdown;

		// Token: 0x04006415 RID: 25621
		private static readonly System.IntPtr NativeFieldInfoPtr_dropdown;

		// Token: 0x04006416 RID: 25622
		private static readonly System.IntPtr NativeFieldInfoPtr_intToProperty;

		// Token: 0x04006417 RID: 25623
		private static readonly System.IntPtr NativeFieldInfoPtr_onSelectionChanged;

		// Token: 0x04006418 RID: 25624
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04006419 RID: 25625
		private static readonly System.IntPtr NativeMethodInfoPtr_PropertyAcquired_Private_Void_Property_0;

		// Token: 0x0400641A RID: 25626
		private static readonly System.IntPtr NativeMethodInfoPtr_ValueChanged_Private_Void_Int32_0;

		// Token: 0x0400641B RID: 25627
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
