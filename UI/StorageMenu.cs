using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Storage;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200068C RID: 1676
	public class StorageMenu : Singleton<StorageMenu>
	{
		// Token: 0x060094BC RID: 38076 RVA: 0x00268110 File Offset: 0x00266310
		// Note: this type is marked as 'beforefieldinit'.
		static StorageMenu()
		{
			Il2CppClassPointerStore<StorageMenu>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "StorageMenu");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr);
			StorageMenu.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr, "<IsOpen>k__BackingField");
			StorageMenu.NativeFieldInfoPtr__OpenedStorageEntity_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr, "<OpenedStorageEntity>k__BackingField");
			StorageMenu.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr, "Canvas");
			StorageMenu.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr, "Container");
			StorageMenu.NativeFieldInfoPtr_TitleLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr, "TitleLabel");
			StorageMenu.NativeFieldInfoPtr_SubtitleLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr, "SubtitleLabel");
			StorageMenu.NativeFieldInfoPtr_SlotContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr, "SlotContainer");
			StorageMenu.NativeFieldInfoPtr_SlotsUIs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr, "SlotsUIs");
			StorageMenu.NativeFieldInfoPtr_SlotGridLayout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr, "SlotGridLayout");
			StorageMenu.NativeFieldInfoPtr_CloseButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr, "CloseButton");
			StorageMenu.NativeFieldInfoPtr_onClosed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr, "onClosed");
			StorageMenu.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr, 100681865);
			StorageMenu.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr, 100681866);
			StorageMenu.NativeMethodInfoPtr_get_OpenedStorageEntity_Public_get_StorageEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr, 100681867);
			StorageMenu.NativeMethodInfoPtr_set_OpenedStorageEntity_Protected_set_Void_StorageEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr, 100681868);
			StorageMenu.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr, 100681869);
			StorageMenu.NativeMethodInfoPtr_Open_Public_Virtual_New_Void_IItemSlotOwner_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr, 100681870);
			StorageMenu.NativeMethodInfoPtr_Open_Public_Virtual_New_Void_StorageEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr, 100681871);
			StorageMenu.NativeMethodInfoPtr_Open_Private_Void_String_String_IItemSlotOwner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr, 100681872);
			StorageMenu.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr, 100681873);
			StorageMenu.NativeMethodInfoPtr_CloseMenu_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr, 100681874);
			StorageMenu.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr, 100681875);
			StorageMenu.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr, 100681876);
		}

		// Token: 0x17002D68 RID: 11624
		// (get) Token: 0x060094BD RID: 38077 RVA: 0x0026830C File Offset: 0x0026650C
		// (set) Token: 0x060094BE RID: 38078 RVA: 0x00268348 File Offset: 0x00266548
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(StorageMenu.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 40119, RefRangeEnd = 40138, XrefRangeStart = 40119, XrefRangeEnd = 40138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageMenu.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002D69 RID: 11625
		// (get) Token: 0x060094BF RID: 38079 RVA: 0x00268388 File Offset: 0x00266588
		// (set) Token: 0x060094C0 RID: 38080 RVA: 0x002683C8 File Offset: 0x002665C8
		public unsafe StorageEntity OpenedStorageEntity
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 20988, RefRangeEnd = 21002, XrefRangeStart = 20988, XrefRangeEnd = 21002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageMenu.NativeMethodInfoPtr_get_OpenedStorageEntity_Public_get_StorageEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorageEntity>(intPtr2) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 21003, RefRangeEnd = 21004, XrefRangeStart = 21003, XrefRangeEnd = 21004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageMenu.NativeMethodInfoPtr_set_OpenedStorageEntity_Protected_set_Void_StorageEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x060094C1 RID: 38081 RVA: 0x0026840C File Offset: 0x0026660C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268534, XrefRangeEnd = 268551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StorageMenu.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060094C2 RID: 38082 RVA: 0x00268448 File Offset: 0x00266648
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268551, XrefRangeEnd = 268555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Open(IItemSlotOwner owner, string title, string subtitle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(owner);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(title);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(subtitle);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StorageMenu.NativeMethodInfoPtr_Open_Public_Virtual_New_Void_IItemSlotOwner_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060094C3 RID: 38083 RVA: 0x002684BC File Offset: 0x002666BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268555, XrefRangeEnd = 268558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Open(StorageEntity entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StorageMenu.NativeMethodInfoPtr_Open_Public_Virtual_New_Void_StorageEntity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060094C4 RID: 38084 RVA: 0x0026850C File Offset: 0x0026670C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 268636, RefRangeEnd = 268638, XrefRangeStart = 268558, XrefRangeEnd = 268636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(string title, string subtitle, IItemSlotOwner owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(subtitle);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageMenu.NativeMethodInfoPtr_Open_Private_Void_String_String_IItemSlotOwner_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060094C5 RID: 38085 RVA: 0x00268574 File Offset: 0x00266774
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268638, XrefRangeEnd = 268644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageMenu.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060094C6 RID: 38086 RVA: 0x002685A8 File Offset: 0x002667A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268644, XrefRangeEnd = 268689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CloseMenu()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StorageMenu.NativeMethodInfoPtr_CloseMenu_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060094C7 RID: 38087 RVA: 0x002685E4 File Offset: 0x002667E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268689, XrefRangeEnd = 268694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageMenu.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060094C8 RID: 38088 RVA: 0x00268628 File Offset: 0x00266828
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268694, XrefRangeEnd = 268697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StorageMenu() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StorageMenu>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageMenu.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060094C9 RID: 38089 RVA: 0x00047B08 File Offset: 0x00045D08
		public StorageMenu(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002D5D RID: 11613
		// (get) Token: 0x060094CA RID: 38090 RVA: 0x00268664 File Offset: 0x00266864
		// (set) Token: 0x060094CB RID: 38091 RVA: 0x00047B11 File Offset: 0x00045D11
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMenu.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMenu.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002D5E RID: 11614
		// (get) Token: 0x060094CC RID: 38092 RVA: 0x0026868C File Offset: 0x0026688C
		// (set) Token: 0x060094CD RID: 38093 RVA: 0x00047B2C File Offset: 0x00045D2C
		public unsafe StorageEntity _OpenedStorageEntity_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMenu.NativeFieldInfoPtr__OpenedStorageEntity_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorageEntity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMenu.NativeFieldInfoPtr__OpenedStorageEntity_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D5F RID: 11615
		// (get) Token: 0x060094CE RID: 38094 RVA: 0x002686BC File Offset: 0x002668BC
		// (set) Token: 0x060094CF RID: 38095 RVA: 0x00047B4B File Offset: 0x00045D4B
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMenu.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMenu.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D60 RID: 11616
		// (get) Token: 0x060094D0 RID: 38096 RVA: 0x002686EC File Offset: 0x002668EC
		// (set) Token: 0x060094D1 RID: 38097 RVA: 0x00047B6A File Offset: 0x00045D6A
		public unsafe RectTransform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMenu.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMenu.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D61 RID: 11617
		// (get) Token: 0x060094D2 RID: 38098 RVA: 0x0026871C File Offset: 0x0026691C
		// (set) Token: 0x060094D3 RID: 38099 RVA: 0x00047B89 File Offset: 0x00045D89
		public unsafe TextMeshProUGUI TitleLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMenu.NativeFieldInfoPtr_TitleLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMenu.NativeFieldInfoPtr_TitleLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D62 RID: 11618
		// (get) Token: 0x060094D4 RID: 38100 RVA: 0x0026874C File Offset: 0x0026694C
		// (set) Token: 0x060094D5 RID: 38101 RVA: 0x00047BA8 File Offset: 0x00045DA8
		public unsafe TextMeshProUGUI SubtitleLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMenu.NativeFieldInfoPtr_SubtitleLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMenu.NativeFieldInfoPtr_SubtitleLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D63 RID: 11619
		// (get) Token: 0x060094D6 RID: 38102 RVA: 0x0026877C File Offset: 0x0026697C
		// (set) Token: 0x060094D7 RID: 38103 RVA: 0x00047BC7 File Offset: 0x00045DC7
		public unsafe RectTransform SlotContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMenu.NativeFieldInfoPtr_SlotContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMenu.NativeFieldInfoPtr_SlotContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D64 RID: 11620
		// (get) Token: 0x060094D8 RID: 38104 RVA: 0x002687AC File Offset: 0x002669AC
		// (set) Token: 0x060094D9 RID: 38105 RVA: 0x00047BE6 File Offset: 0x00045DE6
		public unsafe Il2CppReferenceArray<ItemSlotUI> SlotsUIs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMenu.NativeFieldInfoPtr_SlotsUIs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ItemSlotUI>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMenu.NativeFieldInfoPtr_SlotsUIs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D65 RID: 11621
		// (get) Token: 0x060094DA RID: 38106 RVA: 0x002687DC File Offset: 0x002669DC
		// (set) Token: 0x060094DB RID: 38107 RVA: 0x00047C05 File Offset: 0x00045E05
		public unsafe GridLayoutGroup SlotGridLayout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMenu.NativeFieldInfoPtr_SlotGridLayout);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GridLayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMenu.NativeFieldInfoPtr_SlotGridLayout), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D66 RID: 11622
		// (get) Token: 0x060094DC RID: 38108 RVA: 0x0026880C File Offset: 0x00266A0C
		// (set) Token: 0x060094DD RID: 38109 RVA: 0x00047C24 File Offset: 0x00045E24
		public unsafe RectTransform CloseButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMenu.NativeFieldInfoPtr_CloseButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMenu.NativeFieldInfoPtr_CloseButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D67 RID: 11623
		// (get) Token: 0x060094DE RID: 38110 RVA: 0x0026883C File Offset: 0x00266A3C
		// (set) Token: 0x060094DF RID: 38111 RVA: 0x00047C43 File Offset: 0x00045E43
		public unsafe UnityEvent onClosed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMenu.NativeFieldInfoPtr_onClosed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageMenu.NativeFieldInfoPtr_onClosed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006485 RID: 25733
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04006486 RID: 25734
		private static readonly IntPtr NativeFieldInfoPtr__OpenedStorageEntity_k__BackingField;

		// Token: 0x04006487 RID: 25735
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x04006488 RID: 25736
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04006489 RID: 25737
		private static readonly IntPtr NativeFieldInfoPtr_TitleLabel;

		// Token: 0x0400648A RID: 25738
		private static readonly IntPtr NativeFieldInfoPtr_SubtitleLabel;

		// Token: 0x0400648B RID: 25739
		private static readonly IntPtr NativeFieldInfoPtr_SlotContainer;

		// Token: 0x0400648C RID: 25740
		private static readonly IntPtr NativeFieldInfoPtr_SlotsUIs;

		// Token: 0x0400648D RID: 25741
		private static readonly IntPtr NativeFieldInfoPtr_SlotGridLayout;

		// Token: 0x0400648E RID: 25742
		private static readonly IntPtr NativeFieldInfoPtr_CloseButton;

		// Token: 0x0400648F RID: 25743
		private static readonly IntPtr NativeFieldInfoPtr_onClosed;

		// Token: 0x04006490 RID: 25744
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04006491 RID: 25745
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0;

		// Token: 0x04006492 RID: 25746
		private static readonly IntPtr NativeMethodInfoPtr_get_OpenedStorageEntity_Public_get_StorageEntity_0;

		// Token: 0x04006493 RID: 25747
		private static readonly IntPtr NativeMethodInfoPtr_set_OpenedStorageEntity_Protected_set_Void_StorageEntity_0;

		// Token: 0x04006494 RID: 25748
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04006495 RID: 25749
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Virtual_New_Void_IItemSlotOwner_String_String_0;

		// Token: 0x04006496 RID: 25750
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Virtual_New_Void_StorageEntity_0;

		// Token: 0x04006497 RID: 25751
		private static readonly IntPtr NativeMethodInfoPtr_Open_Private_Void_String_String_IItemSlotOwner_0;

		// Token: 0x04006498 RID: 25752
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04006499 RID: 25753
		private static readonly IntPtr NativeMethodInfoPtr_CloseMenu_Public_Virtual_New_Void_0;

		// Token: 0x0400649A RID: 25754
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x0400649B RID: 25755
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
