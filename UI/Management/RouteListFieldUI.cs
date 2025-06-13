using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Management;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006F2 RID: 1778
	public class RouteListFieldUI : MonoBehaviour
	{
		// Token: 0x06009ED9 RID: 40665 RVA: 0x00286048 File Offset: 0x00284248
		// Note: this type is marked as 'beforefieldinit'.
		static RouteListFieldUI()
		{
			Il2CppClassPointerStore<RouteListFieldUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "RouteListFieldUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RouteListFieldUI>.NativeClassPtr);
			RouteListFieldUI.NativeFieldInfoPtr__Fields_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteListFieldUI>.NativeClassPtr, "<Fields>k__BackingField");
			RouteListFieldUI.NativeFieldInfoPtr_FieldText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteListFieldUI>.NativeClassPtr, "FieldText");
			RouteListFieldUI.NativeFieldInfoPtr_FieldLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteListFieldUI>.NativeClassPtr, "FieldLabel");
			RouteListFieldUI.NativeFieldInfoPtr_RouteEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteListFieldUI>.NativeClassPtr, "RouteEntries");
			RouteListFieldUI.NativeFieldInfoPtr_MultiEditBlocker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteListFieldUI>.NativeClassPtr, "MultiEditBlocker");
			RouteListFieldUI.NativeFieldInfoPtr_AddButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteListFieldUI>.NativeClassPtr, "AddButton");
			RouteListFieldUI.NativeMethodInfoPtr_get_Fields_Public_get_List_1_RouteListField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteListFieldUI>.NativeClassPtr, 100682897);
			RouteListFieldUI.NativeMethodInfoPtr_set_Fields_Protected_set_Void_List_1_RouteListField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteListFieldUI>.NativeClassPtr, 100682898);
			RouteListFieldUI.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteListFieldUI>.NativeClassPtr, 100682899);
			RouteListFieldUI.NativeMethodInfoPtr_Bind_Public_Void_List_1_RouteListField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteListFieldUI>.NativeClassPtr, 100682900);
			RouteListFieldUI.NativeMethodInfoPtr_Refresh_Private_Void_List_1_AdvancedTransitRoute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteListFieldUI>.NativeClassPtr, 100682901);
			RouteListFieldUI.NativeMethodInfoPtr_EntryDeleteClicked_Private_Void_RouteEntryUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteListFieldUI>.NativeClassPtr, 100682902);
			RouteListFieldUI.NativeMethodInfoPtr_AddClicked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteListFieldUI>.NativeClassPtr, 100682903);
			RouteListFieldUI.NativeMethodInfoPtr_RouteChanged_Private_Void_ITransitEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteListFieldUI>.NativeClassPtr, 100682904);
			RouteListFieldUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteListFieldUI>.NativeClassPtr, 100682905);
		}

		// Token: 0x170030BC RID: 12476
		// (get) Token: 0x06009EDA RID: 40666 RVA: 0x002861A4 File Offset: 0x002843A4
		// (set) Token: 0x06009EDB RID: 40667 RVA: 0x002861E4 File Offset: 0x002843E4
		public unsafe List<RouteListField> Fields
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 18718, RefRangeEnd = 18719, XrefRangeStart = 18718, XrefRangeEnd = 18719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteListFieldUI.NativeMethodInfoPtr_get_Fields_Public_get_List_1_RouteListField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RouteListField>>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteListFieldUI.NativeMethodInfoPtr_set_Fields_Protected_set_Void_List_1_RouteListField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06009EDC RID: 40668 RVA: 0x00286228 File Offset: 0x00284428
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281807, XrefRangeEnd = 281829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteListFieldUI.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009EDD RID: 40669 RVA: 0x0028625C File Offset: 0x0028445C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 281858, RefRangeEnd = 281859, XrefRangeStart = 281829, XrefRangeEnd = 281858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Bind(List<RouteListField> field)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(field);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteListFieldUI.NativeMethodInfoPtr_Bind_Public_Void_List_1_RouteListField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009EDE RID: 40670 RVA: 0x002862A0 File Offset: 0x002844A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 281940, RefRangeEnd = 281941, XrefRangeStart = 281859, XrefRangeEnd = 281940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Refresh(List<AdvancedTransitRoute> newVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(newVal);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteListFieldUI.NativeMethodInfoPtr_Refresh_Private_Void_List_1_AdvancedTransitRoute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009EDF RID: 40671 RVA: 0x002862E4 File Offset: 0x002844E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281941, XrefRangeEnd = 281947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EntryDeleteClicked(RouteEntryUI entry)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(entry);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteListFieldUI.NativeMethodInfoPtr_EntryDeleteClicked_Private_Void_RouteEntryUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009EE0 RID: 40672 RVA: 0x00286328 File Offset: 0x00284528
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281947, XrefRangeEnd = 281956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteListFieldUI.NativeMethodInfoPtr_AddClicked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009EE1 RID: 40673 RVA: 0x0028635C File Offset: 0x0028455C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281956, XrefRangeEnd = 281961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RouteChanged(ITransitEntity newEntity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(newEntity);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteListFieldUI.NativeMethodInfoPtr_RouteChanged_Private_Void_ITransitEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009EE2 RID: 40674 RVA: 0x002863A0 File Offset: 0x002845A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281961, XrefRangeEnd = 281973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RouteListFieldUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RouteListFieldUI>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteListFieldUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009EE3 RID: 40675 RVA: 0x0004DA25 File Offset: 0x0004BC25
		public RouteListFieldUI(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170030B6 RID: 12470
		// (get) Token: 0x06009EE4 RID: 40676 RVA: 0x002863DC File Offset: 0x002845DC
		// (set) Token: 0x06009EE5 RID: 40677 RVA: 0x0004DA2E File Offset: 0x0004BC2E
		public unsafe List<RouteListField> _Fields_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RouteListFieldUI.NativeFieldInfoPtr__Fields_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RouteListField>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RouteListFieldUI.NativeFieldInfoPtr__Fields_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030B7 RID: 12471
		// (get) Token: 0x06009EE6 RID: 40678 RVA: 0x0028640C File Offset: 0x0028460C
		// (set) Token: 0x06009EE7 RID: 40679 RVA: 0x0004DA4D File Offset: 0x0004BC4D
		public unsafe string FieldText
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RouteListFieldUI.NativeFieldInfoPtr_FieldText);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RouteListFieldUI.NativeFieldInfoPtr_FieldText), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170030B8 RID: 12472
		// (get) Token: 0x06009EE8 RID: 40680 RVA: 0x00286434 File Offset: 0x00284634
		// (set) Token: 0x06009EE9 RID: 40681 RVA: 0x0004DA6C File Offset: 0x0004BC6C
		public unsafe TextMeshProUGUI FieldLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RouteListFieldUI.NativeFieldInfoPtr_FieldLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RouteListFieldUI.NativeFieldInfoPtr_FieldLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030B9 RID: 12473
		// (get) Token: 0x06009EEA RID: 40682 RVA: 0x00286464 File Offset: 0x00284664
		// (set) Token: 0x06009EEB RID: 40683 RVA: 0x0004DA8B File Offset: 0x0004BC8B
		public unsafe Il2CppReferenceArray<RouteEntryUI> RouteEntries
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RouteListFieldUI.NativeFieldInfoPtr_RouteEntries);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RouteEntryUI>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RouteListFieldUI.NativeFieldInfoPtr_RouteEntries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030BA RID: 12474
		// (get) Token: 0x06009EEC RID: 40684 RVA: 0x00286494 File Offset: 0x00284694
		// (set) Token: 0x06009EED RID: 40685 RVA: 0x0004DAAA File Offset: 0x0004BCAA
		public unsafe RectTransform MultiEditBlocker
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RouteListFieldUI.NativeFieldInfoPtr_MultiEditBlocker);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RouteListFieldUI.NativeFieldInfoPtr_MultiEditBlocker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030BB RID: 12475
		// (get) Token: 0x06009EEE RID: 40686 RVA: 0x002864C4 File Offset: 0x002846C4
		// (set) Token: 0x06009EEF RID: 40687 RVA: 0x0004DAC9 File Offset: 0x0004BCC9
		public unsafe Button AddButton
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RouteListFieldUI.NativeFieldInfoPtr_AddButton);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RouteListFieldUI.NativeFieldInfoPtr_AddButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006AB9 RID: 27321
		private static readonly System.IntPtr NativeFieldInfoPtr__Fields_k__BackingField;

		// Token: 0x04006ABA RID: 27322
		private static readonly System.IntPtr NativeFieldInfoPtr_FieldText;

		// Token: 0x04006ABB RID: 27323
		private static readonly System.IntPtr NativeFieldInfoPtr_FieldLabel;

		// Token: 0x04006ABC RID: 27324
		private static readonly System.IntPtr NativeFieldInfoPtr_RouteEntries;

		// Token: 0x04006ABD RID: 27325
		private static readonly System.IntPtr NativeFieldInfoPtr_MultiEditBlocker;

		// Token: 0x04006ABE RID: 27326
		private static readonly System.IntPtr NativeFieldInfoPtr_AddButton;

		// Token: 0x04006ABF RID: 27327
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Fields_Public_get_List_1_RouteListField_0;

		// Token: 0x04006AC0 RID: 27328
		private static readonly System.IntPtr NativeMethodInfoPtr_set_Fields_Protected_set_Void_List_1_RouteListField_0;

		// Token: 0x04006AC1 RID: 27329
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04006AC2 RID: 27330
		private static readonly System.IntPtr NativeMethodInfoPtr_Bind_Public_Void_List_1_RouteListField_0;

		// Token: 0x04006AC3 RID: 27331
		private static readonly System.IntPtr NativeMethodInfoPtr_Refresh_Private_Void_List_1_AdvancedTransitRoute_0;

		// Token: 0x04006AC4 RID: 27332
		private static readonly System.IntPtr NativeMethodInfoPtr_EntryDeleteClicked_Private_Void_RouteEntryUI_0;

		// Token: 0x04006AC5 RID: 27333
		private static readonly System.IntPtr NativeMethodInfoPtr_AddClicked_Private_Void_0;

		// Token: 0x04006AC6 RID: 27334
		private static readonly System.IntPtr NativeMethodInfoPtr_RouteChanged_Private_Void_ITransitEntity_0;

		// Token: 0x04006AC7 RID: 27335
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BE0 RID: 3040
		[ObfuscatedName("ScheduleOne.UI.Management.RouteListFieldUI+<>c__DisplayClass9_0")]
		public sealed class __c__DisplayClass9_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E12E RID: 57646 RVA: 0x00356874 File Offset: 0x00354A74
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<RouteListFieldUI.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RouteListFieldUI>.NativeClassPtr, "<>c__DisplayClass9_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RouteListFieldUI.__c__DisplayClass9_0>.NativeClassPtr);
				RouteListFieldUI.__c__DisplayClass9_0.NativeFieldInfoPtr_entry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteListFieldUI.__c__DisplayClass9_0>.NativeClassPtr, "entry");
				RouteListFieldUI.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteListFieldUI.__c__DisplayClass9_0>.NativeClassPtr, "<>4__this");
				RouteListFieldUI.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteListFieldUI.__c__DisplayClass9_0>.NativeClassPtr, 100682906);
				RouteListFieldUI.__c__DisplayClass9_0.NativeMethodInfoPtr__Start_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteListFieldUI.__c__DisplayClass9_0>.NativeClassPtr, 100682907);
			}

			// Token: 0x0600E12F RID: 57647 RVA: 0x003568F0 File Offset: 0x00354AF0
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RouteListFieldUI.__c__DisplayClass9_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteListFieldUI.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E130 RID: 57648 RVA: 0x0035692C File Offset: 0x00354B2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281766, XrefRangeEnd = 281807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Start_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteListFieldUI.__c__DisplayClass9_0.NativeMethodInfoPtr__Start_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E131 RID: 57649 RVA: 0x0006D606 File Offset: 0x0006B806
			public __c__DisplayClass9_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004580 RID: 17792
			// (get) Token: 0x0600E132 RID: 57650 RVA: 0x00356960 File Offset: 0x00354B60
			// (set) Token: 0x0600E133 RID: 57651 RVA: 0x0006D60F File Offset: 0x0006B80F
			public unsafe RouteEntryUI entry
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RouteListFieldUI.__c__DisplayClass9_0.NativeFieldInfoPtr_entry);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RouteEntryUI>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RouteListFieldUI.__c__DisplayClass9_0.NativeFieldInfoPtr_entry), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004581 RID: 17793
			// (get) Token: 0x0600E134 RID: 57652 RVA: 0x00356990 File Offset: 0x00354B90
			// (set) Token: 0x0600E135 RID: 57653 RVA: 0x0006D62E File Offset: 0x0006B82E
			public unsafe RouteListFieldUI __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RouteListFieldUI.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RouteListFieldUI>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RouteListFieldUI.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400970A RID: 38666
			private static readonly System.IntPtr NativeFieldInfoPtr_entry;

			// Token: 0x0400970B RID: 38667
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400970C RID: 38668
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400970D RID: 38669
			private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__0_Internal_Void_0;
		}
	}
}
