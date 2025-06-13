using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.Management;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006EF RID: 1775
	public class ObjectListFieldUI : MonoBehaviour
	{
		// Token: 0x06009E8D RID: 40589 RVA: 0x00285110 File Offset: 0x00283310
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectListFieldUI()
		{
			Il2CppClassPointerStore<ObjectListFieldUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "ObjectListFieldUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectListFieldUI>.NativeClassPtr);
			ObjectListFieldUI.NativeFieldInfoPtr__Fields_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectListFieldUI>.NativeClassPtr, "<Fields>k__BackingField");
			ObjectListFieldUI.NativeFieldInfoPtr_FieldText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectListFieldUI>.NativeClassPtr, "FieldText");
			ObjectListFieldUI.NativeFieldInfoPtr_InstructionText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectListFieldUI>.NativeClassPtr, "InstructionText");
			ObjectListFieldUI.NativeFieldInfoPtr_ExtendedInstructionText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectListFieldUI>.NativeClassPtr, "ExtendedInstructionText");
			ObjectListFieldUI.NativeFieldInfoPtr_FieldLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectListFieldUI>.NativeClassPtr, "FieldLabel");
			ObjectListFieldUI.NativeFieldInfoPtr_NoneSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectListFieldUI>.NativeClassPtr, "NoneSelected");
			ObjectListFieldUI.NativeFieldInfoPtr_MultipleSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectListFieldUI>.NativeClassPtr, "MultipleSelected");
			ObjectListFieldUI.NativeFieldInfoPtr_Entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectListFieldUI>.NativeClassPtr, "Entries");
			ObjectListFieldUI.NativeFieldInfoPtr_Button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectListFieldUI>.NativeClassPtr, "Button");
			ObjectListFieldUI.NativeFieldInfoPtr_EditIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectListFieldUI>.NativeClassPtr, "EditIcon");
			ObjectListFieldUI.NativeFieldInfoPtr_NoMultiEdit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectListFieldUI>.NativeClassPtr, "NoMultiEdit");
			ObjectListFieldUI.NativeMethodInfoPtr_get_Fields_Public_get_List_1_ObjectListField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectListFieldUI>.NativeClassPtr, 100682867);
			ObjectListFieldUI.NativeMethodInfoPtr_set_Fields_Protected_set_Void_List_1_ObjectListField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectListFieldUI>.NativeClassPtr, 100682868);
			ObjectListFieldUI.NativeMethodInfoPtr_Bind_Public_Void_List_1_ObjectListField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectListFieldUI>.NativeClassPtr, 100682869);
			ObjectListFieldUI.NativeMethodInfoPtr_Refresh_Private_Void_List_1_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectListFieldUI>.NativeClassPtr, 100682870);
			ObjectListFieldUI.NativeMethodInfoPtr_AreFieldsUniform_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectListFieldUI>.NativeClassPtr, 100682871);
			ObjectListFieldUI.NativeMethodInfoPtr_Clicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectListFieldUI>.NativeClassPtr, 100682872);
			ObjectListFieldUI.NativeMethodInfoPtr_ObjectValid_Private_Boolean_BuildableItem_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectListFieldUI>.NativeClassPtr, 100682873);
			ObjectListFieldUI.NativeMethodInfoPtr_ObjectsSelected_Public_Void_List_1_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectListFieldUI>.NativeClassPtr, 100682874);
			ObjectListFieldUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectListFieldUI>.NativeClassPtr, 100682875);
		}

		// Token: 0x170030A9 RID: 12457
		// (get) Token: 0x06009E8E RID: 40590 RVA: 0x002852D0 File Offset: 0x002834D0
		// (set) Token: 0x06009E8F RID: 40591 RVA: 0x00285310 File Offset: 0x00283510
		public unsafe List<ObjectListField> Fields
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 18718, RefRangeEnd = 18719, XrefRangeStart = 18718, XrefRangeEnd = 18719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectListFieldUI.NativeMethodInfoPtr_get_Fields_Public_get_List_1_ObjectListField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ObjectListField>>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectListFieldUI.NativeMethodInfoPtr_set_Fields_Protected_set_Void_List_1_ObjectListField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06009E90 RID: 40592 RVA: 0x00285354 File Offset: 0x00283554
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 281383, RefRangeEnd = 281387, XrefRangeStart = 281346, XrefRangeEnd = 281383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Bind(List<ObjectListField> field)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(field);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectListFieldUI.NativeMethodInfoPtr_Bind_Public_Void_List_1_ObjectListField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009E91 RID: 40593 RVA: 0x00285398 File Offset: 0x00283598
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 281442, RefRangeEnd = 281443, XrefRangeStart = 281387, XrefRangeEnd = 281442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Refresh(List<BuildableItem> newVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(newVal);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectListFieldUI.NativeMethodInfoPtr_Refresh_Private_Void_List_1_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009E92 RID: 40594 RVA: 0x002853DC File Offset: 0x002835DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 281453, RefRangeEnd = 281455, XrefRangeStart = 281443, XrefRangeEnd = 281453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AreFieldsUniform()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ObjectListFieldUI.NativeMethodInfoPtr_AreFieldsUniform_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06009E93 RID: 40595 RVA: 0x00285418 File Offset: 0x00283618
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281455, XrefRangeEnd = 281493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectListFieldUI.NativeMethodInfoPtr_Clicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009E94 RID: 40596 RVA: 0x0028544C File Offset: 0x0028364C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281493, XrefRangeEnd = 281504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ObjectValid(BuildableItem obj, out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr il2CppString = 0;
			ptr2 = &il2CppString;
			IntPtr returnedException;
			IntPtr obj2 = IL2CPP.il2cpp_runtime_invoke(ObjectListFieldUI.NativeMethodInfoPtr_ObjectValid_Private_Boolean_BuildableItem_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			reason = IL2CPP.Il2CppStringToManaged(il2CppString);
			return *IL2CPP.il2cpp_object_unbox(obj2);
		}

		// Token: 0x06009E95 RID: 40597 RVA: 0x002854B4 File Offset: 0x002836B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281504, XrefRangeEnd = 281528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ObjectsSelected(List<BuildableItem> objs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(objs);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectListFieldUI.NativeMethodInfoPtr_ObjectsSelected_Public_Void_List_1_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009E96 RID: 40598 RVA: 0x002854F8 File Offset: 0x002836F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281528, XrefRangeEnd = 281547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectListFieldUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectListFieldUI>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectListFieldUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009E97 RID: 40599 RVA: 0x0004D787 File Offset: 0x0004B987
		public ObjectListFieldUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700309E RID: 12446
		// (get) Token: 0x06009E98 RID: 40600 RVA: 0x00285534 File Offset: 0x00283734
		// (set) Token: 0x06009E99 RID: 40601 RVA: 0x0004D790 File Offset: 0x0004B990
		public unsafe List<ObjectListField> _Fields_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListFieldUI.NativeFieldInfoPtr__Fields_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ObjectListField>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListFieldUI.NativeFieldInfoPtr__Fields_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700309F RID: 12447
		// (get) Token: 0x06009E9A RID: 40602 RVA: 0x00285564 File Offset: 0x00283764
		// (set) Token: 0x06009E9B RID: 40603 RVA: 0x0004D7AF File Offset: 0x0004B9AF
		public unsafe string FieldText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListFieldUI.NativeFieldInfoPtr_FieldText);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListFieldUI.NativeFieldInfoPtr_FieldText), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170030A0 RID: 12448
		// (get) Token: 0x06009E9C RID: 40604 RVA: 0x0028558C File Offset: 0x0028378C
		// (set) Token: 0x06009E9D RID: 40605 RVA: 0x0004D7CE File Offset: 0x0004B9CE
		public unsafe string InstructionText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListFieldUI.NativeFieldInfoPtr_InstructionText);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListFieldUI.NativeFieldInfoPtr_InstructionText), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170030A1 RID: 12449
		// (get) Token: 0x06009E9E RID: 40606 RVA: 0x002855B4 File Offset: 0x002837B4
		// (set) Token: 0x06009E9F RID: 40607 RVA: 0x0004D7ED File Offset: 0x0004B9ED
		public unsafe string ExtendedInstructionText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListFieldUI.NativeFieldInfoPtr_ExtendedInstructionText);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListFieldUI.NativeFieldInfoPtr_ExtendedInstructionText), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170030A2 RID: 12450
		// (get) Token: 0x06009EA0 RID: 40608 RVA: 0x002855DC File Offset: 0x002837DC
		// (set) Token: 0x06009EA1 RID: 40609 RVA: 0x0004D80C File Offset: 0x0004BA0C
		public unsafe TextMeshProUGUI FieldLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListFieldUI.NativeFieldInfoPtr_FieldLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListFieldUI.NativeFieldInfoPtr_FieldLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030A3 RID: 12451
		// (get) Token: 0x06009EA2 RID: 40610 RVA: 0x0028560C File Offset: 0x0028380C
		// (set) Token: 0x06009EA3 RID: 40611 RVA: 0x0004D82B File Offset: 0x0004BA2B
		public unsafe GameObject NoneSelected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListFieldUI.NativeFieldInfoPtr_NoneSelected);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListFieldUI.NativeFieldInfoPtr_NoneSelected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030A4 RID: 12452
		// (get) Token: 0x06009EA4 RID: 40612 RVA: 0x0028563C File Offset: 0x0028383C
		// (set) Token: 0x06009EA5 RID: 40613 RVA: 0x0004D84A File Offset: 0x0004BA4A
		public unsafe GameObject MultipleSelected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListFieldUI.NativeFieldInfoPtr_MultipleSelected);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListFieldUI.NativeFieldInfoPtr_MultipleSelected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030A5 RID: 12453
		// (get) Token: 0x06009EA6 RID: 40614 RVA: 0x0028566C File Offset: 0x0028386C
		// (set) Token: 0x06009EA7 RID: 40615 RVA: 0x0004D869 File Offset: 0x0004BA69
		public unsafe Il2CppReferenceArray<RectTransform> Entries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListFieldUI.NativeFieldInfoPtr_Entries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListFieldUI.NativeFieldInfoPtr_Entries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030A6 RID: 12454
		// (get) Token: 0x06009EA8 RID: 40616 RVA: 0x0028569C File Offset: 0x0028389C
		// (set) Token: 0x06009EA9 RID: 40617 RVA: 0x0004D888 File Offset: 0x0004BA88
		public unsafe Button Button
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListFieldUI.NativeFieldInfoPtr_Button);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListFieldUI.NativeFieldInfoPtr_Button), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030A7 RID: 12455
		// (get) Token: 0x06009EAA RID: 40618 RVA: 0x002856CC File Offset: 0x002838CC
		// (set) Token: 0x06009EAB RID: 40619 RVA: 0x0004D8A7 File Offset: 0x0004BAA7
		public unsafe GameObject EditIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListFieldUI.NativeFieldInfoPtr_EditIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListFieldUI.NativeFieldInfoPtr_EditIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030A8 RID: 12456
		// (get) Token: 0x06009EAC RID: 40620 RVA: 0x002856FC File Offset: 0x002838FC
		// (set) Token: 0x06009EAD RID: 40621 RVA: 0x0004D8C6 File Offset: 0x0004BAC6
		public unsafe GameObject NoMultiEdit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListFieldUI.NativeFieldInfoPtr_NoMultiEdit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListFieldUI.NativeFieldInfoPtr_NoMultiEdit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006A88 RID: 27272
		private static readonly IntPtr NativeFieldInfoPtr__Fields_k__BackingField;

		// Token: 0x04006A89 RID: 27273
		private static readonly IntPtr NativeFieldInfoPtr_FieldText;

		// Token: 0x04006A8A RID: 27274
		private static readonly IntPtr NativeFieldInfoPtr_InstructionText;

		// Token: 0x04006A8B RID: 27275
		private static readonly IntPtr NativeFieldInfoPtr_ExtendedInstructionText;

		// Token: 0x04006A8C RID: 27276
		private static readonly IntPtr NativeFieldInfoPtr_FieldLabel;

		// Token: 0x04006A8D RID: 27277
		private static readonly IntPtr NativeFieldInfoPtr_NoneSelected;

		// Token: 0x04006A8E RID: 27278
		private static readonly IntPtr NativeFieldInfoPtr_MultipleSelected;

		// Token: 0x04006A8F RID: 27279
		private static readonly IntPtr NativeFieldInfoPtr_Entries;

		// Token: 0x04006A90 RID: 27280
		private static readonly IntPtr NativeFieldInfoPtr_Button;

		// Token: 0x04006A91 RID: 27281
		private static readonly IntPtr NativeFieldInfoPtr_EditIcon;

		// Token: 0x04006A92 RID: 27282
		private static readonly IntPtr NativeFieldInfoPtr_NoMultiEdit;

		// Token: 0x04006A93 RID: 27283
		private static readonly IntPtr NativeMethodInfoPtr_get_Fields_Public_get_List_1_ObjectListField_0;

		// Token: 0x04006A94 RID: 27284
		private static readonly IntPtr NativeMethodInfoPtr_set_Fields_Protected_set_Void_List_1_ObjectListField_0;

		// Token: 0x04006A95 RID: 27285
		private static readonly IntPtr NativeMethodInfoPtr_Bind_Public_Void_List_1_ObjectListField_0;

		// Token: 0x04006A96 RID: 27286
		private static readonly IntPtr NativeMethodInfoPtr_Refresh_Private_Void_List_1_BuildableItem_0;

		// Token: 0x04006A97 RID: 27287
		private static readonly IntPtr NativeMethodInfoPtr_AreFieldsUniform_Private_Boolean_0;

		// Token: 0x04006A98 RID: 27288
		private static readonly IntPtr NativeMethodInfoPtr_Clicked_Public_Void_0;

		// Token: 0x04006A99 RID: 27289
		private static readonly IntPtr NativeMethodInfoPtr_ObjectValid_Private_Boolean_BuildableItem_byref_String_0;

		// Token: 0x04006A9A RID: 27290
		private static readonly IntPtr NativeMethodInfoPtr_ObjectsSelected_Public_Void_List_1_BuildableItem_0;

		// Token: 0x04006A9B RID: 27291
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
