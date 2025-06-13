using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.Management;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006EE RID: 1774
	public class ObjectFieldUI : MonoBehaviour
	{
		// Token: 0x06009E6E RID: 40558 RVA: 0x00284AD4 File Offset: 0x00282CD4
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectFieldUI()
		{
			Il2CppClassPointerStore<ObjectFieldUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "ObjectFieldUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectFieldUI>.NativeClassPtr);
			ObjectFieldUI.NativeFieldInfoPtr__Fields_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectFieldUI>.NativeClassPtr, "<Fields>k__BackingField");
			ObjectFieldUI.NativeFieldInfoPtr_InstructionText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectFieldUI>.NativeClassPtr, "InstructionText");
			ObjectFieldUI.NativeFieldInfoPtr_ExtendedInstructionText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectFieldUI>.NativeClassPtr, "ExtendedInstructionText");
			ObjectFieldUI.NativeFieldInfoPtr_FieldLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectFieldUI>.NativeClassPtr, "FieldLabel");
			ObjectFieldUI.NativeFieldInfoPtr_IconImg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectFieldUI>.NativeClassPtr, "IconImg");
			ObjectFieldUI.NativeFieldInfoPtr_SelectionLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectFieldUI>.NativeClassPtr, "SelectionLabel");
			ObjectFieldUI.NativeFieldInfoPtr_NoneSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectFieldUI>.NativeClassPtr, "NoneSelected");
			ObjectFieldUI.NativeFieldInfoPtr_MultipleSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectFieldUI>.NativeClassPtr, "MultipleSelected");
			ObjectFieldUI.NativeFieldInfoPtr_ClearButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectFieldUI>.NativeClassPtr, "ClearButton");
			ObjectFieldUI.NativeMethodInfoPtr_get_Fields_Public_get_List_1_ObjectField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectFieldUI>.NativeClassPtr, 100682853);
			ObjectFieldUI.NativeMethodInfoPtr_set_Fields_Protected_set_Void_List_1_ObjectField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectFieldUI>.NativeClassPtr, 100682854);
			ObjectFieldUI.NativeMethodInfoPtr_Bind_Public_Void_List_1_ObjectField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectFieldUI>.NativeClassPtr, 100682855);
			ObjectFieldUI.NativeMethodInfoPtr_Refresh_Private_Void_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectFieldUI>.NativeClassPtr, 100682856);
			ObjectFieldUI.NativeMethodInfoPtr_AreFieldsUniform_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectFieldUI>.NativeClassPtr, 100682857);
			ObjectFieldUI.NativeMethodInfoPtr_Clicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectFieldUI>.NativeClassPtr, 100682858);
			ObjectFieldUI.NativeMethodInfoPtr_ObjectValid_Private_Boolean_BuildableItem_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectFieldUI>.NativeClassPtr, 100682859);
			ObjectFieldUI.NativeMethodInfoPtr_ObjectsSelected_Public_Void_List_1_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectFieldUI>.NativeClassPtr, 100682860);
			ObjectFieldUI.NativeMethodInfoPtr_ObjectSelected_Private_Void_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectFieldUI>.NativeClassPtr, 100682861);
			ObjectFieldUI.NativeMethodInfoPtr_ClearClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectFieldUI>.NativeClassPtr, 100682862);
			ObjectFieldUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectFieldUI>.NativeClassPtr, 100682863);
		}

		// Token: 0x1700309D RID: 12445
		// (get) Token: 0x06009E6F RID: 40559 RVA: 0x00284C94 File Offset: 0x00282E94
		// (set) Token: 0x06009E70 RID: 40560 RVA: 0x00284CD4 File Offset: 0x00282ED4
		public unsafe List<ObjectField> Fields
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 18718, RefRangeEnd = 18719, XrefRangeStart = 18718, XrefRangeEnd = 18719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectFieldUI.NativeMethodInfoPtr_get_Fields_Public_get_List_1_ObjectField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ObjectField>>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectFieldUI.NativeMethodInfoPtr_set_Fields_Protected_set_Void_List_1_ObjectField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06009E71 RID: 40561 RVA: 0x00284D18 File Offset: 0x00282F18
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 281159, RefRangeEnd = 281172, XrefRangeStart = 281132, XrefRangeEnd = 281159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Bind(List<ObjectField> field)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(field);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectFieldUI.NativeMethodInfoPtr_Bind_Public_Void_List_1_ObjectField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009E72 RID: 40562 RVA: 0x00284D5C File Offset: 0x00282F5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 281215, RefRangeEnd = 281216, XrefRangeStart = 281172, XrefRangeEnd = 281215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Refresh(BuildableItem newVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(newVal);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectFieldUI.NativeMethodInfoPtr_Refresh_Private_Void_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009E73 RID: 40563 RVA: 0x00284DA0 File Offset: 0x00282FA0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 281227, RefRangeEnd = 281229, XrefRangeStart = 281216, XrefRangeEnd = 281227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AreFieldsUniform()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ObjectFieldUI.NativeMethodInfoPtr_AreFieldsUniform_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06009E74 RID: 40564 RVA: 0x00284DDC File Offset: 0x00282FDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281229, XrefRangeEnd = 281286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectFieldUI.NativeMethodInfoPtr_Clicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009E75 RID: 40565 RVA: 0x00284E10 File Offset: 0x00283010
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281286, XrefRangeEnd = 281297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ObjectValid(BuildableItem obj, out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ref System.IntPtr ptr2 = ref ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)];
			System.IntPtr il2CppString = 0;
			ptr2 = &il2CppString;
			System.IntPtr returnedException;
			System.IntPtr obj2 = IL2CPP.il2cpp_runtime_invoke(ObjectFieldUI.NativeMethodInfoPtr_ObjectValid_Private_Boolean_BuildableItem_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			reason = IL2CPP.Il2CppStringToManaged(il2CppString);
			return *IL2CPP.il2cpp_object_unbox(obj2);
		}

		// Token: 0x06009E76 RID: 40566 RVA: 0x00284E78 File Offset: 0x00283078
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281297, XrefRangeEnd = 281304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ObjectsSelected(List<BuildableItem> objs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(objs);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectFieldUI.NativeMethodInfoPtr_ObjectsSelected_Public_Void_List_1_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009E77 RID: 40567 RVA: 0x00284EBC File Offset: 0x002830BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 281328, RefRangeEnd = 281330, XrefRangeStart = 281304, XrefRangeEnd = 281328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ObjectSelected(BuildableItem obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectFieldUI.NativeMethodInfoPtr_ObjectSelected_Private_Void_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009E78 RID: 40568 RVA: 0x00284F00 File Offset: 0x00283100
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281330, XrefRangeEnd = 281331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectFieldUI.NativeMethodInfoPtr_ClearClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009E79 RID: 40569 RVA: 0x00284F34 File Offset: 0x00283134
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281331, XrefRangeEnd = 281346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectFieldUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectFieldUI>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectFieldUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009E7A RID: 40570 RVA: 0x0004D667 File Offset: 0x0004B867
		public ObjectFieldUI(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003094 RID: 12436
		// (get) Token: 0x06009E7B RID: 40571 RVA: 0x00284F70 File Offset: 0x00283170
		// (set) Token: 0x06009E7C RID: 40572 RVA: 0x0004D670 File Offset: 0x0004B870
		public unsafe List<ObjectField> _Fields_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectFieldUI.NativeFieldInfoPtr__Fields_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ObjectField>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectFieldUI.NativeFieldInfoPtr__Fields_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003095 RID: 12437
		// (get) Token: 0x06009E7D RID: 40573 RVA: 0x00284FA0 File Offset: 0x002831A0
		// (set) Token: 0x06009E7E RID: 40574 RVA: 0x0004D68F File Offset: 0x0004B88F
		public unsafe string InstructionText
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectFieldUI.NativeFieldInfoPtr_InstructionText);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectFieldUI.NativeFieldInfoPtr_InstructionText), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17003096 RID: 12438
		// (get) Token: 0x06009E7F RID: 40575 RVA: 0x00284FC8 File Offset: 0x002831C8
		// (set) Token: 0x06009E80 RID: 40576 RVA: 0x0004D6AE File Offset: 0x0004B8AE
		public unsafe string ExtendedInstructionText
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectFieldUI.NativeFieldInfoPtr_ExtendedInstructionText);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectFieldUI.NativeFieldInfoPtr_ExtendedInstructionText), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17003097 RID: 12439
		// (get) Token: 0x06009E81 RID: 40577 RVA: 0x00284FF0 File Offset: 0x002831F0
		// (set) Token: 0x06009E82 RID: 40578 RVA: 0x0004D6CD File Offset: 0x0004B8CD
		public unsafe TextMeshProUGUI FieldLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectFieldUI.NativeFieldInfoPtr_FieldLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectFieldUI.NativeFieldInfoPtr_FieldLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003098 RID: 12440
		// (get) Token: 0x06009E83 RID: 40579 RVA: 0x00285020 File Offset: 0x00283220
		// (set) Token: 0x06009E84 RID: 40580 RVA: 0x0004D6EC File Offset: 0x0004B8EC
		public unsafe Image IconImg
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectFieldUI.NativeFieldInfoPtr_IconImg);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectFieldUI.NativeFieldInfoPtr_IconImg), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003099 RID: 12441
		// (get) Token: 0x06009E85 RID: 40581 RVA: 0x00285050 File Offset: 0x00283250
		// (set) Token: 0x06009E86 RID: 40582 RVA: 0x0004D70B File Offset: 0x0004B90B
		public unsafe TextMeshProUGUI SelectionLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectFieldUI.NativeFieldInfoPtr_SelectionLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectFieldUI.NativeFieldInfoPtr_SelectionLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700309A RID: 12442
		// (get) Token: 0x06009E87 RID: 40583 RVA: 0x00285080 File Offset: 0x00283280
		// (set) Token: 0x06009E88 RID: 40584 RVA: 0x0004D72A File Offset: 0x0004B92A
		public unsafe GameObject NoneSelected
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectFieldUI.NativeFieldInfoPtr_NoneSelected);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectFieldUI.NativeFieldInfoPtr_NoneSelected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700309B RID: 12443
		// (get) Token: 0x06009E89 RID: 40585 RVA: 0x002850B0 File Offset: 0x002832B0
		// (set) Token: 0x06009E8A RID: 40586 RVA: 0x0004D749 File Offset: 0x0004B949
		public unsafe GameObject MultipleSelected
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectFieldUI.NativeFieldInfoPtr_MultipleSelected);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectFieldUI.NativeFieldInfoPtr_MultipleSelected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700309C RID: 12444
		// (get) Token: 0x06009E8B RID: 40587 RVA: 0x002850E0 File Offset: 0x002832E0
		// (set) Token: 0x06009E8C RID: 40588 RVA: 0x0004D768 File Offset: 0x0004B968
		public unsafe RectTransform ClearButton
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectFieldUI.NativeFieldInfoPtr_ClearButton);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectFieldUI.NativeFieldInfoPtr_ClearButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006A74 RID: 27252
		private static readonly System.IntPtr NativeFieldInfoPtr__Fields_k__BackingField;

		// Token: 0x04006A75 RID: 27253
		private static readonly System.IntPtr NativeFieldInfoPtr_InstructionText;

		// Token: 0x04006A76 RID: 27254
		private static readonly System.IntPtr NativeFieldInfoPtr_ExtendedInstructionText;

		// Token: 0x04006A77 RID: 27255
		private static readonly System.IntPtr NativeFieldInfoPtr_FieldLabel;

		// Token: 0x04006A78 RID: 27256
		private static readonly System.IntPtr NativeFieldInfoPtr_IconImg;

		// Token: 0x04006A79 RID: 27257
		private static readonly System.IntPtr NativeFieldInfoPtr_SelectionLabel;

		// Token: 0x04006A7A RID: 27258
		private static readonly System.IntPtr NativeFieldInfoPtr_NoneSelected;

		// Token: 0x04006A7B RID: 27259
		private static readonly System.IntPtr NativeFieldInfoPtr_MultipleSelected;

		// Token: 0x04006A7C RID: 27260
		private static readonly System.IntPtr NativeFieldInfoPtr_ClearButton;

		// Token: 0x04006A7D RID: 27261
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Fields_Public_get_List_1_ObjectField_0;

		// Token: 0x04006A7E RID: 27262
		private static readonly System.IntPtr NativeMethodInfoPtr_set_Fields_Protected_set_Void_List_1_ObjectField_0;

		// Token: 0x04006A7F RID: 27263
		private static readonly System.IntPtr NativeMethodInfoPtr_Bind_Public_Void_List_1_ObjectField_0;

		// Token: 0x04006A80 RID: 27264
		private static readonly System.IntPtr NativeMethodInfoPtr_Refresh_Private_Void_BuildableItem_0;

		// Token: 0x04006A81 RID: 27265
		private static readonly System.IntPtr NativeMethodInfoPtr_AreFieldsUniform_Private_Boolean_0;

		// Token: 0x04006A82 RID: 27266
		private static readonly System.IntPtr NativeMethodInfoPtr_Clicked_Public_Void_0;

		// Token: 0x04006A83 RID: 27267
		private static readonly System.IntPtr NativeMethodInfoPtr_ObjectValid_Private_Boolean_BuildableItem_byref_String_0;

		// Token: 0x04006A84 RID: 27268
		private static readonly System.IntPtr NativeMethodInfoPtr_ObjectsSelected_Public_Void_List_1_BuildableItem_0;

		// Token: 0x04006A85 RID: 27269
		private static readonly System.IntPtr NativeMethodInfoPtr_ObjectSelected_Private_Void_BuildableItem_0;

		// Token: 0x04006A86 RID: 27270
		private static readonly System.IntPtr NativeMethodInfoPtr_ClearClicked_Public_Void_0;

		// Token: 0x04006A87 RID: 27271
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BDE RID: 3038
		[ObfuscatedName("ScheduleOne.UI.Management.ObjectFieldUI+<>c")]
		[System.Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600E11E RID: 57630 RVA: 0x003565D8 File Offset: 0x003547D8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ObjectFieldUI.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ObjectFieldUI>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectFieldUI.__c>.NativeClassPtr);
				ObjectFieldUI.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectFieldUI.__c>.NativeClassPtr, "<>9");
				ObjectFieldUI.__c.NativeFieldInfoPtr___9__13_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectFieldUI.__c>.NativeClassPtr, "<>9__13_0");
				ObjectFieldUI.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectFieldUI.__c>.NativeClassPtr, 100682865);
				ObjectFieldUI.__c.NativeMethodInfoPtr__Refresh_b__13_0_Internal_Boolean_ObjectField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectFieldUI.__c>.NativeClassPtr, 100682866);
			}

			// Token: 0x0600E11F RID: 57631 RVA: 0x00356654 File Offset: 0x00354854
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectFieldUI.__c>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectFieldUI.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E120 RID: 57632 RVA: 0x00356690 File Offset: 0x00354890
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281127, XrefRangeEnd = 281132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Refresh_b__13_0(ObjectField x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ObjectFieldUI.__c.NativeMethodInfoPtr__Refresh_b__13_0_Internal_Boolean_ObjectField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600E121 RID: 57633 RVA: 0x0006D596 File Offset: 0x0006B796
			public __c(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700457C RID: 17788
			// (get) Token: 0x0600E122 RID: 57634 RVA: 0x003566E0 File Offset: 0x003548E0
			// (set) Token: 0x0600E123 RID: 57635 RVA: 0x0006D59F File Offset: 0x0006B79F
			public unsafe static ObjectFieldUI.__c __9
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ObjectFieldUI.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectFieldUI.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ObjectFieldUI.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700457D RID: 17789
			// (get) Token: 0x0600E124 RID: 57636 RVA: 0x00356708 File Offset: 0x00354908
			// (set) Token: 0x0600E125 RID: 57637 RVA: 0x0006D5B1 File Offset: 0x0006B7B1
			public unsafe static Il2CppSystem.Func<ObjectField, bool> __9__13_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ObjectFieldUI.__c.NativeFieldInfoPtr___9__13_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<ObjectField, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ObjectFieldUI.__c.NativeFieldInfoPtr___9__13_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009702 RID: 38658
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009703 RID: 38659
			private static readonly System.IntPtr NativeFieldInfoPtr___9__13_0;

			// Token: 0x04009704 RID: 38660
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009705 RID: 38661
			private static readonly System.IntPtr NativeMethodInfoPtr__Refresh_b__13_0_Internal_Boolean_ObjectField_0;
		}
	}
}
