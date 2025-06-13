using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Management;
using Il2CppScheduleOne.NPCs;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006EC RID: 1772
	public class NPCFieldUI : MonoBehaviour
	{
		// Token: 0x06009E40 RID: 40512 RVA: 0x002841D0 File Offset: 0x002823D0
		// Note: this type is marked as 'beforefieldinit'.
		static NPCFieldUI()
		{
			Il2CppClassPointerStore<NPCFieldUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "NPCFieldUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCFieldUI>.NativeClassPtr);
			NPCFieldUI.NativeFieldInfoPtr__Fields_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCFieldUI>.NativeClassPtr, "<Fields>k__BackingField");
			NPCFieldUI.NativeFieldInfoPtr_FieldLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCFieldUI>.NativeClassPtr, "FieldLabel");
			NPCFieldUI.NativeFieldInfoPtr_IconImg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCFieldUI>.NativeClassPtr, "IconImg");
			NPCFieldUI.NativeFieldInfoPtr_SelectionLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCFieldUI>.NativeClassPtr, "SelectionLabel");
			NPCFieldUI.NativeFieldInfoPtr_NoneSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCFieldUI>.NativeClassPtr, "NoneSelected");
			NPCFieldUI.NativeFieldInfoPtr_MultipleSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCFieldUI>.NativeClassPtr, "MultipleSelected");
			NPCFieldUI.NativeFieldInfoPtr_ClearButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCFieldUI>.NativeClassPtr, "ClearButton");
			NPCFieldUI.NativeMethodInfoPtr_get_Fields_Public_get_List_1_NPCField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCFieldUI>.NativeClassPtr, 100682834);
			NPCFieldUI.NativeMethodInfoPtr_set_Fields_Protected_set_Void_List_1_NPCField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCFieldUI>.NativeClassPtr, 100682835);
			NPCFieldUI.NativeMethodInfoPtr_Bind_Public_Void_List_1_NPCField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCFieldUI>.NativeClassPtr, 100682836);
			NPCFieldUI.NativeMethodInfoPtr_Refresh_Private_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCFieldUI>.NativeClassPtr, 100682837);
			NPCFieldUI.NativeMethodInfoPtr_AreFieldsUniform_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCFieldUI>.NativeClassPtr, 100682838);
			NPCFieldUI.NativeMethodInfoPtr_Clicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCFieldUI>.NativeClassPtr, 100682839);
			NPCFieldUI.NativeMethodInfoPtr_NPCSelected_Public_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCFieldUI>.NativeClassPtr, 100682840);
			NPCFieldUI.NativeMethodInfoPtr_ClearClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCFieldUI>.NativeClassPtr, 100682841);
			NPCFieldUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCFieldUI>.NativeClassPtr, 100682842);
		}

		// Token: 0x1700308C RID: 12428
		// (get) Token: 0x06009E41 RID: 40513 RVA: 0x00284340 File Offset: 0x00282540
		// (set) Token: 0x06009E42 RID: 40514 RVA: 0x00284380 File Offset: 0x00282580
		public unsafe List<NPCField> Fields
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 18718, RefRangeEnd = 18719, XrefRangeStart = 18718, XrefRangeEnd = 18719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCFieldUI.NativeMethodInfoPtr_get_Fields_Public_get_List_1_NPCField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NPCField>>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCFieldUI.NativeMethodInfoPtr_set_Fields_Protected_set_Void_List_1_NPCField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06009E43 RID: 40515 RVA: 0x002843C4 File Offset: 0x002825C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280900, XrefRangeEnd = 280927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Bind(List<NPCField> field)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(field);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCFieldUI.NativeMethodInfoPtr_Bind_Public_Void_List_1_NPCField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009E44 RID: 40516 RVA: 0x00284408 File Offset: 0x00282608
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 280973, RefRangeEnd = 280974, XrefRangeStart = 280927, XrefRangeEnd = 280973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Refresh(NPC newVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(newVal);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCFieldUI.NativeMethodInfoPtr_Refresh_Private_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009E45 RID: 40517 RVA: 0x0028444C File Offset: 0x0028264C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 280985, RefRangeEnd = 280987, XrefRangeStart = 280974, XrefRangeEnd = 280985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AreFieldsUniform()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NPCFieldUI.NativeMethodInfoPtr_AreFieldsUniform_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06009E46 RID: 40518 RVA: 0x00284488 File Offset: 0x00282688
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280987, XrefRangeEnd = 281004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCFieldUI.NativeMethodInfoPtr_Clicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009E47 RID: 40519 RVA: 0x002844BC File Offset: 0x002826BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 281026, RefRangeEnd = 281027, XrefRangeStart = 281004, XrefRangeEnd = 281026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NPCSelected(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCFieldUI.NativeMethodInfoPtr_NPCSelected_Public_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009E48 RID: 40520 RVA: 0x00284500 File Offset: 0x00282700
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281027, XrefRangeEnd = 281028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCFieldUI.NativeMethodInfoPtr_ClearClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009E49 RID: 40521 RVA: 0x00284534 File Offset: 0x00282734
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281028, XrefRangeEnd = 281036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCFieldUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCFieldUI>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCFieldUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009E4A RID: 40522 RVA: 0x0004D4C2 File Offset: 0x0004B6C2
		public NPCFieldUI(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003085 RID: 12421
		// (get) Token: 0x06009E4B RID: 40523 RVA: 0x00284570 File Offset: 0x00282770
		// (set) Token: 0x06009E4C RID: 40524 RVA: 0x0004D4CB File Offset: 0x0004B6CB
		public unsafe List<NPCField> _Fields_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCFieldUI.NativeFieldInfoPtr__Fields_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NPCField>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCFieldUI.NativeFieldInfoPtr__Fields_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003086 RID: 12422
		// (get) Token: 0x06009E4D RID: 40525 RVA: 0x002845A0 File Offset: 0x002827A0
		// (set) Token: 0x06009E4E RID: 40526 RVA: 0x0004D4EA File Offset: 0x0004B6EA
		public unsafe TextMeshProUGUI FieldLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCFieldUI.NativeFieldInfoPtr_FieldLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCFieldUI.NativeFieldInfoPtr_FieldLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003087 RID: 12423
		// (get) Token: 0x06009E4F RID: 40527 RVA: 0x002845D0 File Offset: 0x002827D0
		// (set) Token: 0x06009E50 RID: 40528 RVA: 0x0004D509 File Offset: 0x0004B709
		public unsafe Image IconImg
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCFieldUI.NativeFieldInfoPtr_IconImg);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCFieldUI.NativeFieldInfoPtr_IconImg), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003088 RID: 12424
		// (get) Token: 0x06009E51 RID: 40529 RVA: 0x00284600 File Offset: 0x00282800
		// (set) Token: 0x06009E52 RID: 40530 RVA: 0x0004D528 File Offset: 0x0004B728
		public unsafe TextMeshProUGUI SelectionLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCFieldUI.NativeFieldInfoPtr_SelectionLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCFieldUI.NativeFieldInfoPtr_SelectionLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003089 RID: 12425
		// (get) Token: 0x06009E53 RID: 40531 RVA: 0x00284630 File Offset: 0x00282830
		// (set) Token: 0x06009E54 RID: 40532 RVA: 0x0004D547 File Offset: 0x0004B747
		public unsafe GameObject NoneSelected
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCFieldUI.NativeFieldInfoPtr_NoneSelected);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCFieldUI.NativeFieldInfoPtr_NoneSelected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700308A RID: 12426
		// (get) Token: 0x06009E55 RID: 40533 RVA: 0x00284660 File Offset: 0x00282860
		// (set) Token: 0x06009E56 RID: 40534 RVA: 0x0004D566 File Offset: 0x0004B766
		public unsafe GameObject MultipleSelected
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCFieldUI.NativeFieldInfoPtr_MultipleSelected);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCFieldUI.NativeFieldInfoPtr_MultipleSelected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700308B RID: 12427
		// (get) Token: 0x06009E57 RID: 40535 RVA: 0x00284690 File Offset: 0x00282890
		// (set) Token: 0x06009E58 RID: 40536 RVA: 0x0004D585 File Offset: 0x0004B785
		public unsafe RectTransform ClearButton
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCFieldUI.NativeFieldInfoPtr_ClearButton);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCFieldUI.NativeFieldInfoPtr_ClearButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006A57 RID: 27223
		private static readonly System.IntPtr NativeFieldInfoPtr__Fields_k__BackingField;

		// Token: 0x04006A58 RID: 27224
		private static readonly System.IntPtr NativeFieldInfoPtr_FieldLabel;

		// Token: 0x04006A59 RID: 27225
		private static readonly System.IntPtr NativeFieldInfoPtr_IconImg;

		// Token: 0x04006A5A RID: 27226
		private static readonly System.IntPtr NativeFieldInfoPtr_SelectionLabel;

		// Token: 0x04006A5B RID: 27227
		private static readonly System.IntPtr NativeFieldInfoPtr_NoneSelected;

		// Token: 0x04006A5C RID: 27228
		private static readonly System.IntPtr NativeFieldInfoPtr_MultipleSelected;

		// Token: 0x04006A5D RID: 27229
		private static readonly System.IntPtr NativeFieldInfoPtr_ClearButton;

		// Token: 0x04006A5E RID: 27230
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Fields_Public_get_List_1_NPCField_0;

		// Token: 0x04006A5F RID: 27231
		private static readonly System.IntPtr NativeMethodInfoPtr_set_Fields_Protected_set_Void_List_1_NPCField_0;

		// Token: 0x04006A60 RID: 27232
		private static readonly System.IntPtr NativeMethodInfoPtr_Bind_Public_Void_List_1_NPCField_0;

		// Token: 0x04006A61 RID: 27233
		private static readonly System.IntPtr NativeMethodInfoPtr_Refresh_Private_Void_NPC_0;

		// Token: 0x04006A62 RID: 27234
		private static readonly System.IntPtr NativeMethodInfoPtr_AreFieldsUniform_Private_Boolean_0;

		// Token: 0x04006A63 RID: 27235
		private static readonly System.IntPtr NativeMethodInfoPtr_Clicked_Public_Void_0;

		// Token: 0x04006A64 RID: 27236
		private static readonly System.IntPtr NativeMethodInfoPtr_NPCSelected_Public_Void_NPC_0;

		// Token: 0x04006A65 RID: 27237
		private static readonly System.IntPtr NativeMethodInfoPtr_ClearClicked_Public_Void_0;

		// Token: 0x04006A66 RID: 27238
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BDD RID: 3037
		[ObfuscatedName("ScheduleOne.UI.Management.NPCFieldUI+<>c")]
		[System.Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600E116 RID: 57622 RVA: 0x00356480 File Offset: 0x00354680
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<NPCFieldUI.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCFieldUI>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCFieldUI.__c>.NativeClassPtr);
				NPCFieldUI.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCFieldUI.__c>.NativeClassPtr, "<>9");
				NPCFieldUI.__c.NativeFieldInfoPtr___9__11_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCFieldUI.__c>.NativeClassPtr, "<>9__11_0");
				NPCFieldUI.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCFieldUI.__c>.NativeClassPtr, 100682844);
				NPCFieldUI.__c.NativeMethodInfoPtr__Refresh_b__11_0_Internal_Boolean_NPCField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCFieldUI.__c>.NativeClassPtr, 100682845);
			}

			// Token: 0x0600E117 RID: 57623 RVA: 0x003564FC File Offset: 0x003546FC
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCFieldUI.__c>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCFieldUI.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E118 RID: 57624 RVA: 0x00356538 File Offset: 0x00354738
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280895, XrefRangeEnd = 280900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Refresh_b__11_0(NPCField x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NPCFieldUI.__c.NativeMethodInfoPtr__Refresh_b__11_0_Internal_Boolean_NPCField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600E119 RID: 57625 RVA: 0x0006D569 File Offset: 0x0006B769
			public __c(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700457A RID: 17786
			// (get) Token: 0x0600E11A RID: 57626 RVA: 0x00356588 File Offset: 0x00354788
			// (set) Token: 0x0600E11B RID: 57627 RVA: 0x0006D572 File Offset: 0x0006B772
			public unsafe static NPCFieldUI.__c __9
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NPCFieldUI.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCFieldUI.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NPCFieldUI.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700457B RID: 17787
			// (get) Token: 0x0600E11C RID: 57628 RVA: 0x003565B0 File Offset: 0x003547B0
			// (set) Token: 0x0600E11D RID: 57629 RVA: 0x0006D584 File Offset: 0x0006B784
			public unsafe static Il2CppSystem.Func<NPCField, bool> __9__11_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NPCFieldUI.__c.NativeFieldInfoPtr___9__11_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<NPCField, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NPCFieldUI.__c.NativeFieldInfoPtr___9__11_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040096FE RID: 38654
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040096FF RID: 38655
			private static readonly System.IntPtr NativeFieldInfoPtr___9__11_0;

			// Token: 0x04009700 RID: 38656
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009701 RID: 38657
			private static readonly System.IntPtr NativeMethodInfoPtr__Refresh_b__11_0_Internal_Boolean_NPCField_0;
		}
	}
}
