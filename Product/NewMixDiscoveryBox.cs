using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Interaction;
using Il2CppScheduleOne.Packaging;
using Il2CppScheduleOne.Properties;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x020005C6 RID: 1478
	public class NewMixDiscoveryBox : MonoBehaviour
	{
		// Token: 0x0600803F RID: 32831 RVA: 0x002273A8 File Offset: 0x002255A8
		// Note: this type is marked as 'beforefieldinit'.
		static NewMixDiscoveryBox()
		{
			Il2CppClassPointerStore<NewMixDiscoveryBox>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "NewMixDiscoveryBox");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NewMixDiscoveryBox>.NativeClassPtr);
			NewMixDiscoveryBox.NativeFieldInfoPtr_isOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixDiscoveryBox>.NativeClassPtr, "isOpen");
			NewMixDiscoveryBox.NativeFieldInfoPtr_CameraPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixDiscoveryBox>.NativeClassPtr, "CameraPosition");
			NewMixDiscoveryBox.NativeFieldInfoPtr_PropertiesText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixDiscoveryBox>.NativeClassPtr, "PropertiesText");
			NewMixDiscoveryBox.NativeFieldInfoPtr_Visuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixDiscoveryBox>.NativeClassPtr, "Visuals");
			NewMixDiscoveryBox.NativeFieldInfoPtr_Animation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixDiscoveryBox>.NativeClassPtr, "Animation");
			NewMixDiscoveryBox.NativeFieldInfoPtr_IntObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixDiscoveryBox>.NativeClassPtr, "IntObj");
			NewMixDiscoveryBox.NativeFieldInfoPtr_Lid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixDiscoveryBox>.NativeClassPtr, "Lid");
			NewMixDiscoveryBox.NativeFieldInfoPtr_closedLidPose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixDiscoveryBox>.NativeClassPtr, "closedLidPose");
			NewMixDiscoveryBox.NativeFieldInfoPtr_currentMix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixDiscoveryBox>.NativeClassPtr, "currentMix");
			NewMixDiscoveryBox.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixDiscoveryBox>.NativeClassPtr, 100679433);
			NewMixDiscoveryBox.NativeMethodInfoPtr_ShowProduct_Public_Void_ProductDefinition_List_1_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixDiscoveryBox>.NativeClassPtr, 100679434);
			NewMixDiscoveryBox.NativeMethodInfoPtr_CloseCase_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixDiscoveryBox>.NativeClassPtr, 100679435);
			NewMixDiscoveryBox.NativeMethodInfoPtr_OpenCase_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixDiscoveryBox>.NativeClassPtr, 100679436);
			NewMixDiscoveryBox.NativeMethodInfoPtr_Interacted_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixDiscoveryBox>.NativeClassPtr, 100679437);
			NewMixDiscoveryBox.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixDiscoveryBox>.NativeClassPtr, 100679438);
		}

		// Token: 0x06008040 RID: 32832 RVA: 0x00227504 File Offset: 0x00225704
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242604, XrefRangeEnd = 242622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewMixDiscoveryBox.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008041 RID: 32833 RVA: 0x00227538 File Offset: 0x00225738
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 242824, RefRangeEnd = 242826, XrefRangeStart = 242622, XrefRangeEnd = 242824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowProduct(ProductDefinition baseDefinition, List<Property> properties)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseDefinition);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(properties);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewMixDiscoveryBox.NativeMethodInfoPtr_ShowProduct_Public_Void_ProductDefinition_List_1_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008042 RID: 32834 RVA: 0x0022758C File Offset: 0x0022578C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242826, XrefRangeEnd = 242828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CloseCase()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewMixDiscoveryBox.NativeMethodInfoPtr_CloseCase_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008043 RID: 32835 RVA: 0x002275C0 File Offset: 0x002257C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242828, XrefRangeEnd = 242832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenCase()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewMixDiscoveryBox.NativeMethodInfoPtr_OpenCase_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008044 RID: 32836 RVA: 0x002275F4 File Offset: 0x002257F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242832, XrefRangeEnd = 242837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewMixDiscoveryBox.NativeMethodInfoPtr_Interacted_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008045 RID: 32837 RVA: 0x00227628 File Offset: 0x00225828
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NewMixDiscoveryBox() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NewMixDiscoveryBox>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewMixDiscoveryBox.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008046 RID: 32838 RVA: 0x0003CAB3 File Offset: 0x0003ACB3
		public NewMixDiscoveryBox(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002693 RID: 9875
		// (get) Token: 0x06008047 RID: 32839 RVA: 0x00227664 File Offset: 0x00225864
		// (set) Token: 0x06008048 RID: 32840 RVA: 0x0003CABC File Offset: 0x0003ACBC
		public unsafe bool isOpen
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixDiscoveryBox.NativeFieldInfoPtr_isOpen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixDiscoveryBox.NativeFieldInfoPtr_isOpen)) = value;
			}
		}

		// Token: 0x17002694 RID: 9876
		// (get) Token: 0x06008049 RID: 32841 RVA: 0x0022768C File Offset: 0x0022588C
		// (set) Token: 0x0600804A RID: 32842 RVA: 0x0003CAD7 File Offset: 0x0003ACD7
		public unsafe Transform CameraPosition
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixDiscoveryBox.NativeFieldInfoPtr_CameraPosition);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixDiscoveryBox.NativeFieldInfoPtr_CameraPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002695 RID: 9877
		// (get) Token: 0x0600804B RID: 32843 RVA: 0x002276BC File Offset: 0x002258BC
		// (set) Token: 0x0600804C RID: 32844 RVA: 0x0003CAF6 File Offset: 0x0003ACF6
		public unsafe TextMeshPro PropertiesText
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixDiscoveryBox.NativeFieldInfoPtr_PropertiesText);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshPro>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixDiscoveryBox.NativeFieldInfoPtr_PropertiesText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002696 RID: 9878
		// (get) Token: 0x0600804D RID: 32845 RVA: 0x002276EC File Offset: 0x002258EC
		// (set) Token: 0x0600804E RID: 32846 RVA: 0x0003CB15 File Offset: 0x0003AD15
		public unsafe Il2CppReferenceArray<NewMixDiscoveryBox.DrugTypeVisuals> Visuals
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixDiscoveryBox.NativeFieldInfoPtr_Visuals);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<NewMixDiscoveryBox.DrugTypeVisuals>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixDiscoveryBox.NativeFieldInfoPtr_Visuals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002697 RID: 9879
		// (get) Token: 0x0600804F RID: 32847 RVA: 0x0022771C File Offset: 0x0022591C
		// (set) Token: 0x06008050 RID: 32848 RVA: 0x0003CB34 File Offset: 0x0003AD34
		public unsafe Animation Animation
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixDiscoveryBox.NativeFieldInfoPtr_Animation);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixDiscoveryBox.NativeFieldInfoPtr_Animation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002698 RID: 9880
		// (get) Token: 0x06008051 RID: 32849 RVA: 0x0022774C File Offset: 0x0022594C
		// (set) Token: 0x06008052 RID: 32850 RVA: 0x0003CB53 File Offset: 0x0003AD53
		public unsafe InteractableObject IntObj
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixDiscoveryBox.NativeFieldInfoPtr_IntObj);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixDiscoveryBox.NativeFieldInfoPtr_IntObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002699 RID: 9881
		// (get) Token: 0x06008053 RID: 32851 RVA: 0x0022777C File Offset: 0x0022597C
		// (set) Token: 0x06008054 RID: 32852 RVA: 0x0003CB72 File Offset: 0x0003AD72
		public unsafe Transform Lid
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixDiscoveryBox.NativeFieldInfoPtr_Lid);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixDiscoveryBox.NativeFieldInfoPtr_Lid), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700269A RID: 9882
		// (get) Token: 0x06008055 RID: 32853 RVA: 0x002277AC File Offset: 0x002259AC
		// (set) Token: 0x06008056 RID: 32854 RVA: 0x0003CB91 File Offset: 0x0003AD91
		public unsafe Pose closedLidPose
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixDiscoveryBox.NativeFieldInfoPtr_closedLidPose);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixDiscoveryBox.NativeFieldInfoPtr_closedLidPose)) = value;
			}
		}

		// Token: 0x1700269B RID: 9883
		// (get) Token: 0x06008057 RID: 32855 RVA: 0x002277D4 File Offset: 0x002259D4
		// (set) Token: 0x06008058 RID: 32856 RVA: 0x0003CBAC File Offset: 0x0003ADAC
		public unsafe NewMixOperation currentMix
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixDiscoveryBox.NativeFieldInfoPtr_currentMix);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NewMixOperation>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixDiscoveryBox.NativeFieldInfoPtr_currentMix), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005750 RID: 22352
		private static readonly System.IntPtr NativeFieldInfoPtr_isOpen;

		// Token: 0x04005751 RID: 22353
		private static readonly System.IntPtr NativeFieldInfoPtr_CameraPosition;

		// Token: 0x04005752 RID: 22354
		private static readonly System.IntPtr NativeFieldInfoPtr_PropertiesText;

		// Token: 0x04005753 RID: 22355
		private static readonly System.IntPtr NativeFieldInfoPtr_Visuals;

		// Token: 0x04005754 RID: 22356
		private static readonly System.IntPtr NativeFieldInfoPtr_Animation;

		// Token: 0x04005755 RID: 22357
		private static readonly System.IntPtr NativeFieldInfoPtr_IntObj;

		// Token: 0x04005756 RID: 22358
		private static readonly System.IntPtr NativeFieldInfoPtr_Lid;

		// Token: 0x04005757 RID: 22359
		private static readonly System.IntPtr NativeFieldInfoPtr_closedLidPose;

		// Token: 0x04005758 RID: 22360
		private static readonly System.IntPtr NativeFieldInfoPtr_currentMix;

		// Token: 0x04005759 RID: 22361
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x0400575A RID: 22362
		private static readonly System.IntPtr NativeMethodInfoPtr_ShowProduct_Public_Void_ProductDefinition_List_1_Property_0;

		// Token: 0x0400575B RID: 22363
		private static readonly System.IntPtr NativeMethodInfoPtr_CloseCase_Private_Void_0;

		// Token: 0x0400575C RID: 22364
		private static readonly System.IntPtr NativeMethodInfoPtr_OpenCase_Private_Void_0;

		// Token: 0x0400575D RID: 22365
		private static readonly System.IntPtr NativeMethodInfoPtr_Interacted_Private_Void_0;

		// Token: 0x0400575E RID: 22366
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B14 RID: 2836
		[System.Serializable]
		public class DrugTypeVisuals : Il2CppSystem.Object
		{
			// Token: 0x0600D948 RID: 55624 RVA: 0x0034004C File Offset: 0x0033E24C
			// Note: this type is marked as 'beforefieldinit'.
			static DrugTypeVisuals()
			{
				Il2CppClassPointerStore<NewMixDiscoveryBox.DrugTypeVisuals>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NewMixDiscoveryBox>.NativeClassPtr, "DrugTypeVisuals");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NewMixDiscoveryBox.DrugTypeVisuals>.NativeClassPtr);
				NewMixDiscoveryBox.DrugTypeVisuals.NativeFieldInfoPtr_DrugType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixDiscoveryBox.DrugTypeVisuals>.NativeClassPtr, "DrugType");
				NewMixDiscoveryBox.DrugTypeVisuals.NativeFieldInfoPtr_Visuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixDiscoveryBox.DrugTypeVisuals>.NativeClassPtr, "Visuals");
				NewMixDiscoveryBox.DrugTypeVisuals.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixDiscoveryBox.DrugTypeVisuals>.NativeClassPtr, 100679439);
			}

			// Token: 0x0600D949 RID: 55625 RVA: 0x003400B4 File Offset: 0x0033E2B4
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DrugTypeVisuals() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NewMixDiscoveryBox.DrugTypeVisuals>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewMixDiscoveryBox.DrugTypeVisuals.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D94A RID: 55626 RVA: 0x000696DE File Offset: 0x000678DE
			public DrugTypeVisuals(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700430D RID: 17165
			// (get) Token: 0x0600D94B RID: 55627 RVA: 0x003400F0 File Offset: 0x0033E2F0
			// (set) Token: 0x0600D94C RID: 55628 RVA: 0x000696E7 File Offset: 0x000678E7
			public unsafe EDrugType DrugType
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixDiscoveryBox.DrugTypeVisuals.NativeFieldInfoPtr_DrugType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixDiscoveryBox.DrugTypeVisuals.NativeFieldInfoPtr_DrugType)) = value;
				}
			}

			// Token: 0x1700430E RID: 17166
			// (get) Token: 0x0600D94D RID: 55629 RVA: 0x00340118 File Offset: 0x0033E318
			// (set) Token: 0x0600D94E RID: 55630 RVA: 0x00069702 File Offset: 0x00067902
			public unsafe FilledPackagingVisuals Visuals
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixDiscoveryBox.DrugTypeVisuals.NativeFieldInfoPtr_Visuals);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FilledPackagingVisuals>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixDiscoveryBox.DrugTypeVisuals.NativeFieldInfoPtr_Visuals), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400925D RID: 37469
			private static readonly System.IntPtr NativeFieldInfoPtr_DrugType;

			// Token: 0x0400925E RID: 37470
			private static readonly System.IntPtr NativeFieldInfoPtr_Visuals;

			// Token: 0x0400925F RID: 37471
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000B15 RID: 2837
		[ObfuscatedName("ScheduleOne.Product.NewMixDiscoveryBox+<>c")]
		[System.Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D94F RID: 55631 RVA: 0x00340148 File Offset: 0x0033E348
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<NewMixDiscoveryBox.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NewMixDiscoveryBox>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NewMixDiscoveryBox.__c>.NativeClassPtr);
				NewMixDiscoveryBox.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixDiscoveryBox.__c>.NativeClassPtr, "<>9");
				NewMixDiscoveryBox.__c.NativeFieldInfoPtr___9__11_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixDiscoveryBox.__c>.NativeClassPtr, "<>9__11_0");
				NewMixDiscoveryBox.__c.NativeFieldInfoPtr___9__11_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixDiscoveryBox.__c>.NativeClassPtr, "<>9__11_1");
				NewMixDiscoveryBox.__c.NativeFieldInfoPtr___9__11_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixDiscoveryBox.__c>.NativeClassPtr, "<>9__11_2");
				NewMixDiscoveryBox.__c.NativeFieldInfoPtr___9__11_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixDiscoveryBox.__c>.NativeClassPtr, "<>9__11_3");
				NewMixDiscoveryBox.__c.NativeFieldInfoPtr___9__11_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixDiscoveryBox.__c>.NativeClassPtr, "<>9__11_4");
				NewMixDiscoveryBox.__c.NativeFieldInfoPtr___9__11_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixDiscoveryBox.__c>.NativeClassPtr, "<>9__11_5");
				NewMixDiscoveryBox.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixDiscoveryBox.__c>.NativeClassPtr, 100679441);
				NewMixDiscoveryBox.__c.NativeMethodInfoPtr__ShowProduct_b__11_0_Internal_Boolean_DrugTypeVisuals_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixDiscoveryBox.__c>.NativeClassPtr, 100679442);
				NewMixDiscoveryBox.__c.NativeMethodInfoPtr__ShowProduct_b__11_1_Internal_Boolean_DrugTypeVisuals_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixDiscoveryBox.__c>.NativeClassPtr, 100679443);
				NewMixDiscoveryBox.__c.NativeMethodInfoPtr__ShowProduct_b__11_2_Internal_Boolean_DrugTypeVisuals_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixDiscoveryBox.__c>.NativeClassPtr, 100679444);
				NewMixDiscoveryBox.__c.NativeMethodInfoPtr__ShowProduct_b__11_3_Internal_Boolean_DrugTypeVisuals_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixDiscoveryBox.__c>.NativeClassPtr, 100679445);
				NewMixDiscoveryBox.__c.NativeMethodInfoPtr__ShowProduct_b__11_4_Internal_Boolean_DrugTypeVisuals_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixDiscoveryBox.__c>.NativeClassPtr, 100679446);
				NewMixDiscoveryBox.__c.NativeMethodInfoPtr__ShowProduct_b__11_5_Internal_Boolean_DrugTypeVisuals_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixDiscoveryBox.__c>.NativeClassPtr, 100679447);
			}

			// Token: 0x0600D950 RID: 55632 RVA: 0x0034028C File Offset: 0x0033E48C
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NewMixDiscoveryBox.__c>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewMixDiscoveryBox.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D951 RID: 55633 RVA: 0x003402C8 File Offset: 0x0033E4C8
			[CallerCount(0)]
			public unsafe bool _ShowProduct_b__11_0(NewMixDiscoveryBox.DrugTypeVisuals x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NewMixDiscoveryBox.__c.NativeMethodInfoPtr__ShowProduct_b__11_0_Internal_Boolean_DrugTypeVisuals_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D952 RID: 55634 RVA: 0x00340318 File Offset: 0x0033E518
			[CallerCount(0)]
			public unsafe bool _ShowProduct_b__11_1(NewMixDiscoveryBox.DrugTypeVisuals x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NewMixDiscoveryBox.__c.NativeMethodInfoPtr__ShowProduct_b__11_1_Internal_Boolean_DrugTypeVisuals_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D953 RID: 55635 RVA: 0x00340368 File Offset: 0x0033E568
			[CallerCount(0)]
			public unsafe bool _ShowProduct_b__11_2(NewMixDiscoveryBox.DrugTypeVisuals x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NewMixDiscoveryBox.__c.NativeMethodInfoPtr__ShowProduct_b__11_2_Internal_Boolean_DrugTypeVisuals_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D954 RID: 55636 RVA: 0x003403B8 File Offset: 0x0033E5B8
			[CallerCount(0)]
			public unsafe bool _ShowProduct_b__11_3(NewMixDiscoveryBox.DrugTypeVisuals x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NewMixDiscoveryBox.__c.NativeMethodInfoPtr__ShowProduct_b__11_3_Internal_Boolean_DrugTypeVisuals_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D955 RID: 55637 RVA: 0x00340408 File Offset: 0x0033E608
			[CallerCount(0)]
			public unsafe bool _ShowProduct_b__11_4(NewMixDiscoveryBox.DrugTypeVisuals x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NewMixDiscoveryBox.__c.NativeMethodInfoPtr__ShowProduct_b__11_4_Internal_Boolean_DrugTypeVisuals_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D956 RID: 55638 RVA: 0x00340458 File Offset: 0x0033E658
			[CallerCount(0)]
			public unsafe bool _ShowProduct_b__11_5(NewMixDiscoveryBox.DrugTypeVisuals x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NewMixDiscoveryBox.__c.NativeMethodInfoPtr__ShowProduct_b__11_5_Internal_Boolean_DrugTypeVisuals_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D957 RID: 55639 RVA: 0x00069721 File Offset: 0x00067921
			public __c(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700430F RID: 17167
			// (get) Token: 0x0600D958 RID: 55640 RVA: 0x003404A8 File Offset: 0x0033E6A8
			// (set) Token: 0x0600D959 RID: 55641 RVA: 0x0006972A File Offset: 0x0006792A
			public unsafe static NewMixDiscoveryBox.__c __9
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NewMixDiscoveryBox.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NewMixDiscoveryBox.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NewMixDiscoveryBox.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004310 RID: 17168
			// (get) Token: 0x0600D95A RID: 55642 RVA: 0x003404D0 File Offset: 0x0033E6D0
			// (set) Token: 0x0600D95B RID: 55643 RVA: 0x0006973C File Offset: 0x0006793C
			public unsafe static Il2CppSystem.Func<NewMixDiscoveryBox.DrugTypeVisuals, bool> __9__11_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NewMixDiscoveryBox.__c.NativeFieldInfoPtr___9__11_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<NewMixDiscoveryBox.DrugTypeVisuals, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NewMixDiscoveryBox.__c.NativeFieldInfoPtr___9__11_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004311 RID: 17169
			// (get) Token: 0x0600D95C RID: 55644 RVA: 0x003404F8 File Offset: 0x0033E6F8
			// (set) Token: 0x0600D95D RID: 55645 RVA: 0x0006974E File Offset: 0x0006794E
			public unsafe static Il2CppSystem.Func<NewMixDiscoveryBox.DrugTypeVisuals, bool> __9__11_1
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NewMixDiscoveryBox.__c.NativeFieldInfoPtr___9__11_1, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<NewMixDiscoveryBox.DrugTypeVisuals, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NewMixDiscoveryBox.__c.NativeFieldInfoPtr___9__11_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004312 RID: 17170
			// (get) Token: 0x0600D95E RID: 55646 RVA: 0x00340520 File Offset: 0x0033E720
			// (set) Token: 0x0600D95F RID: 55647 RVA: 0x00069760 File Offset: 0x00067960
			public unsafe static Il2CppSystem.Func<NewMixDiscoveryBox.DrugTypeVisuals, bool> __9__11_2
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NewMixDiscoveryBox.__c.NativeFieldInfoPtr___9__11_2, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<NewMixDiscoveryBox.DrugTypeVisuals, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NewMixDiscoveryBox.__c.NativeFieldInfoPtr___9__11_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004313 RID: 17171
			// (get) Token: 0x0600D960 RID: 55648 RVA: 0x00340548 File Offset: 0x0033E748
			// (set) Token: 0x0600D961 RID: 55649 RVA: 0x00069772 File Offset: 0x00067972
			public unsafe static Il2CppSystem.Func<NewMixDiscoveryBox.DrugTypeVisuals, bool> __9__11_3
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NewMixDiscoveryBox.__c.NativeFieldInfoPtr___9__11_3, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<NewMixDiscoveryBox.DrugTypeVisuals, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NewMixDiscoveryBox.__c.NativeFieldInfoPtr___9__11_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004314 RID: 17172
			// (get) Token: 0x0600D962 RID: 55650 RVA: 0x00340570 File Offset: 0x0033E770
			// (set) Token: 0x0600D963 RID: 55651 RVA: 0x00069784 File Offset: 0x00067984
			public unsafe static Il2CppSystem.Func<NewMixDiscoveryBox.DrugTypeVisuals, bool> __9__11_4
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NewMixDiscoveryBox.__c.NativeFieldInfoPtr___9__11_4, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<NewMixDiscoveryBox.DrugTypeVisuals, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NewMixDiscoveryBox.__c.NativeFieldInfoPtr___9__11_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004315 RID: 17173
			// (get) Token: 0x0600D964 RID: 55652 RVA: 0x00340598 File Offset: 0x0033E798
			// (set) Token: 0x0600D965 RID: 55653 RVA: 0x00069796 File Offset: 0x00067996
			public unsafe static Il2CppSystem.Func<NewMixDiscoveryBox.DrugTypeVisuals, bool> __9__11_5
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NewMixDiscoveryBox.__c.NativeFieldInfoPtr___9__11_5, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<NewMixDiscoveryBox.DrugTypeVisuals, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NewMixDiscoveryBox.__c.NativeFieldInfoPtr___9__11_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009260 RID: 37472
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009261 RID: 37473
			private static readonly System.IntPtr NativeFieldInfoPtr___9__11_0;

			// Token: 0x04009262 RID: 37474
			private static readonly System.IntPtr NativeFieldInfoPtr___9__11_1;

			// Token: 0x04009263 RID: 37475
			private static readonly System.IntPtr NativeFieldInfoPtr___9__11_2;

			// Token: 0x04009264 RID: 37476
			private static readonly System.IntPtr NativeFieldInfoPtr___9__11_3;

			// Token: 0x04009265 RID: 37477
			private static readonly System.IntPtr NativeFieldInfoPtr___9__11_4;

			// Token: 0x04009266 RID: 37478
			private static readonly System.IntPtr NativeFieldInfoPtr___9__11_5;

			// Token: 0x04009267 RID: 37479
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009268 RID: 37480
			private static readonly System.IntPtr NativeMethodInfoPtr__ShowProduct_b__11_0_Internal_Boolean_DrugTypeVisuals_0;

			// Token: 0x04009269 RID: 37481
			private static readonly System.IntPtr NativeMethodInfoPtr__ShowProduct_b__11_1_Internal_Boolean_DrugTypeVisuals_0;

			// Token: 0x0400926A RID: 37482
			private static readonly System.IntPtr NativeMethodInfoPtr__ShowProduct_b__11_2_Internal_Boolean_DrugTypeVisuals_0;

			// Token: 0x0400926B RID: 37483
			private static readonly System.IntPtr NativeMethodInfoPtr__ShowProduct_b__11_3_Internal_Boolean_DrugTypeVisuals_0;

			// Token: 0x0400926C RID: 37484
			private static readonly System.IntPtr NativeMethodInfoPtr__ShowProduct_b__11_4_Internal_Boolean_DrugTypeVisuals_0;

			// Token: 0x0400926D RID: 37485
			private static readonly System.IntPtr NativeMethodInfoPtr__ShowProduct_b__11_5_Internal_Boolean_DrugTypeVisuals_0;
		}
	}
}
