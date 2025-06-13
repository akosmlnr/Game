using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000663 RID: 1635
	public class GenericUIScreen : MonoBehaviour
	{
		// Token: 0x06008F92 RID: 36754 RVA: 0x00258F24 File Offset: 0x00257124
		// Note: this type is marked as 'beforefieldinit'.
		static GenericUIScreen()
		{
			Il2CppClassPointerStore<GenericUIScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "GenericUIScreen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericUIScreen>.NativeClassPtr);
			GenericUIScreen.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericUIScreen>.NativeClassPtr, "<IsOpen>k__BackingField");
			GenericUIScreen.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericUIScreen>.NativeClassPtr, "Name");
			GenericUIScreen.NativeFieldInfoPtr_UseExitActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericUIScreen>.NativeClassPtr, "UseExitActions");
			GenericUIScreen.NativeFieldInfoPtr_ExitActionPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericUIScreen>.NativeClassPtr, "ExitActionPriority");
			GenericUIScreen.NativeFieldInfoPtr_CanExitWithRightClick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericUIScreen>.NativeClassPtr, "CanExitWithRightClick");
			GenericUIScreen.NativeFieldInfoPtr_ReenableControlsOnClose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericUIScreen>.NativeClassPtr, "ReenableControlsOnClose");
			GenericUIScreen.NativeFieldInfoPtr_ReenableInventoryOnClose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericUIScreen>.NativeClassPtr, "ReenableInventoryOnClose");
			GenericUIScreen.NativeFieldInfoPtr_ReenableEquippingOnClose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericUIScreen>.NativeClassPtr, "ReenableEquippingOnClose");
			GenericUIScreen.NativeFieldInfoPtr_onOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericUIScreen>.NativeClassPtr, "onOpen");
			GenericUIScreen.NativeFieldInfoPtr_onClose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericUIScreen>.NativeClassPtr, "onClose");
			GenericUIScreen.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericUIScreen>.NativeClassPtr, 100681239);
			GenericUIScreen.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericUIScreen>.NativeClassPtr, 100681240);
			GenericUIScreen.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericUIScreen>.NativeClassPtr, 100681241);
			GenericUIScreen.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericUIScreen>.NativeClassPtr, 100681242);
			GenericUIScreen.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericUIScreen>.NativeClassPtr, 100681243);
			GenericUIScreen.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericUIScreen>.NativeClassPtr, 100681244);
			GenericUIScreen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericUIScreen>.NativeClassPtr, 100681245);
		}

		// Token: 0x17002BA1 RID: 11169
		// (get) Token: 0x06008F93 RID: 36755 RVA: 0x002590A8 File Offset: 0x002572A8
		// (set) Token: 0x06008F94 RID: 36756 RVA: 0x002590E4 File Offset: 0x002572E4
		public unsafe bool IsOpen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 37513, RefRangeEnd = 37514, XrefRangeStart = 37513, XrefRangeEnd = 37514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GenericUIScreen.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 37514, RefRangeEnd = 37516, XrefRangeStart = 37514, XrefRangeEnd = 37516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericUIScreen.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06008F95 RID: 36757 RVA: 0x00259124 File Offset: 0x00257324
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261775, XrefRangeEnd = 261785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericUIScreen.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008F96 RID: 36758 RVA: 0x00259158 File Offset: 0x00257358
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 261808, RefRangeEnd = 261810, XrefRangeStart = 261785, XrefRangeEnd = 261808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericUIScreen.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008F97 RID: 36759 RVA: 0x0025918C File Offset: 0x0025738C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 261837, RefRangeEnd = 261838, XrefRangeStart = 261810, XrefRangeEnd = 261837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericUIScreen.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008F98 RID: 36760 RVA: 0x002591C0 File Offset: 0x002573C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261838, XrefRangeEnd = 261840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericUIScreen.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008F99 RID: 36761 RVA: 0x00259204 File Offset: 0x00257404
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261840, XrefRangeEnd = 261841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GenericUIScreen() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericUIScreen>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericUIScreen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008F9A RID: 36762 RVA: 0x000449C7 File Offset: 0x00042BC7
		public GenericUIScreen(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002B97 RID: 11159
		// (get) Token: 0x06008F9B RID: 36763 RVA: 0x00259240 File Offset: 0x00257440
		// (set) Token: 0x06008F9C RID: 36764 RVA: 0x000449D0 File Offset: 0x00042BD0
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericUIScreen.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericUIScreen.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002B98 RID: 11160
		// (get) Token: 0x06008F9D RID: 36765 RVA: 0x00259268 File Offset: 0x00257468
		// (set) Token: 0x06008F9E RID: 36766 RVA: 0x000449EB File Offset: 0x00042BEB
		public unsafe string Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericUIScreen.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericUIScreen.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002B99 RID: 11161
		// (get) Token: 0x06008F9F RID: 36767 RVA: 0x00259290 File Offset: 0x00257490
		// (set) Token: 0x06008FA0 RID: 36768 RVA: 0x00044A0A File Offset: 0x00042C0A
		public unsafe bool UseExitActions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericUIScreen.NativeFieldInfoPtr_UseExitActions);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericUIScreen.NativeFieldInfoPtr_UseExitActions)) = value;
			}
		}

		// Token: 0x17002B9A RID: 11162
		// (get) Token: 0x06008FA1 RID: 36769 RVA: 0x002592B8 File Offset: 0x002574B8
		// (set) Token: 0x06008FA2 RID: 36770 RVA: 0x00044A25 File Offset: 0x00042C25
		public unsafe int ExitActionPriority
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericUIScreen.NativeFieldInfoPtr_ExitActionPriority);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericUIScreen.NativeFieldInfoPtr_ExitActionPriority)) = value;
			}
		}

		// Token: 0x17002B9B RID: 11163
		// (get) Token: 0x06008FA3 RID: 36771 RVA: 0x002592E0 File Offset: 0x002574E0
		// (set) Token: 0x06008FA4 RID: 36772 RVA: 0x00044A40 File Offset: 0x00042C40
		public unsafe bool CanExitWithRightClick
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericUIScreen.NativeFieldInfoPtr_CanExitWithRightClick);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericUIScreen.NativeFieldInfoPtr_CanExitWithRightClick)) = value;
			}
		}

		// Token: 0x17002B9C RID: 11164
		// (get) Token: 0x06008FA5 RID: 36773 RVA: 0x00259308 File Offset: 0x00257508
		// (set) Token: 0x06008FA6 RID: 36774 RVA: 0x00044A5B File Offset: 0x00042C5B
		public unsafe bool ReenableControlsOnClose
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericUIScreen.NativeFieldInfoPtr_ReenableControlsOnClose);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericUIScreen.NativeFieldInfoPtr_ReenableControlsOnClose)) = value;
			}
		}

		// Token: 0x17002B9D RID: 11165
		// (get) Token: 0x06008FA7 RID: 36775 RVA: 0x00259330 File Offset: 0x00257530
		// (set) Token: 0x06008FA8 RID: 36776 RVA: 0x00044A76 File Offset: 0x00042C76
		public unsafe bool ReenableInventoryOnClose
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericUIScreen.NativeFieldInfoPtr_ReenableInventoryOnClose);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericUIScreen.NativeFieldInfoPtr_ReenableInventoryOnClose)) = value;
			}
		}

		// Token: 0x17002B9E RID: 11166
		// (get) Token: 0x06008FA9 RID: 36777 RVA: 0x00259358 File Offset: 0x00257558
		// (set) Token: 0x06008FAA RID: 36778 RVA: 0x00044A91 File Offset: 0x00042C91
		public unsafe bool ReenableEquippingOnClose
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericUIScreen.NativeFieldInfoPtr_ReenableEquippingOnClose);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericUIScreen.NativeFieldInfoPtr_ReenableEquippingOnClose)) = value;
			}
		}

		// Token: 0x17002B9F RID: 11167
		// (get) Token: 0x06008FAB RID: 36779 RVA: 0x00259380 File Offset: 0x00257580
		// (set) Token: 0x06008FAC RID: 36780 RVA: 0x00044AAC File Offset: 0x00042CAC
		public unsafe UnityEvent onOpen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericUIScreen.NativeFieldInfoPtr_onOpen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericUIScreen.NativeFieldInfoPtr_onOpen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BA0 RID: 11168
		// (get) Token: 0x06008FAD RID: 36781 RVA: 0x002593B0 File Offset: 0x002575B0
		// (set) Token: 0x06008FAE RID: 36782 RVA: 0x00044ACB File Offset: 0x00042CCB
		public unsafe UnityEvent onClose
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericUIScreen.NativeFieldInfoPtr_onClose);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericUIScreen.NativeFieldInfoPtr_onClose), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400614E RID: 24910
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x0400614F RID: 24911
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x04006150 RID: 24912
		private static readonly IntPtr NativeFieldInfoPtr_UseExitActions;

		// Token: 0x04006151 RID: 24913
		private static readonly IntPtr NativeFieldInfoPtr_ExitActionPriority;

		// Token: 0x04006152 RID: 24914
		private static readonly IntPtr NativeFieldInfoPtr_CanExitWithRightClick;

		// Token: 0x04006153 RID: 24915
		private static readonly IntPtr NativeFieldInfoPtr_ReenableControlsOnClose;

		// Token: 0x04006154 RID: 24916
		private static readonly IntPtr NativeFieldInfoPtr_ReenableInventoryOnClose;

		// Token: 0x04006155 RID: 24917
		private static readonly IntPtr NativeFieldInfoPtr_ReenableEquippingOnClose;

		// Token: 0x04006156 RID: 24918
		private static readonly IntPtr NativeFieldInfoPtr_onOpen;

		// Token: 0x04006157 RID: 24919
		private static readonly IntPtr NativeFieldInfoPtr_onClose;

		// Token: 0x04006158 RID: 24920
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04006159 RID: 24921
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0;

		// Token: 0x0400615A RID: 24922
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400615B RID: 24923
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

		// Token: 0x0400615C RID: 24924
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x0400615D RID: 24925
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x0400615E RID: 24926
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
