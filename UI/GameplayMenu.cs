using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000660 RID: 1632
	public class GameplayMenu : Singleton<GameplayMenu>
	{
		// Token: 0x06008F39 RID: 36665 RVA: 0x00257E08 File Offset: 0x00256008
		// Note: this type is marked as 'beforefieldinit'.
		static GameplayMenu()
		{
			Il2CppClassPointerStore<GameplayMenu>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "GameplayMenu");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameplayMenu>.NativeClassPtr);
			GameplayMenu.NativeFieldInfoPtr_OpenVerticalOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenu>.NativeClassPtr, "OpenVerticalOffset");
			GameplayMenu.NativeFieldInfoPtr_ClosedVerticalOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenu>.NativeClassPtr, "ClosedVerticalOffset");
			GameplayMenu.NativeFieldInfoPtr_OpenTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenu>.NativeClassPtr, "OpenTime");
			GameplayMenu.NativeFieldInfoPtr_SlideTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenu>.NativeClassPtr, "SlideTime");
			GameplayMenu.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenu>.NativeClassPtr, "<IsOpen>k__BackingField");
			GameplayMenu.NativeFieldInfoPtr__CurrentScreen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenu>.NativeClassPtr, "<CurrentScreen>k__BackingField");
			GameplayMenu.NativeFieldInfoPtr_OverlayCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenu>.NativeClassPtr, "OverlayCamera");
			GameplayMenu.NativeFieldInfoPtr_OverlayLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenu>.NativeClassPtr, "OverlayLight");
			GameplayMenu.NativeFieldInfoPtr_ContainerOffset_PhoneScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenu>.NativeClassPtr, "ContainerOffset_PhoneScreen");
			GameplayMenu.NativeFieldInfoPtr_openCloseRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenu>.NativeClassPtr, "openCloseRoutine");
			GameplayMenu.NativeFieldInfoPtr_screenChangeRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenu>.NativeClassPtr, "screenChangeRoutine");
			GameplayMenu.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenu>.NativeClassPtr, 100681182);
			GameplayMenu.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenu>.NativeClassPtr, 100681183);
			GameplayMenu.NativeMethodInfoPtr_get_CharacterScreenEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenu>.NativeClassPtr, 100681184);
			GameplayMenu.NativeMethodInfoPtr_get_CurrentScreen_Public_get_EGameplayScreen_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenu>.NativeClassPtr, 100681185);
			GameplayMenu.NativeMethodInfoPtr_set_CurrentScreen_Protected_set_Void_EGameplayScreen_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenu>.NativeClassPtr, 100681186);
			GameplayMenu.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenu>.NativeClassPtr, 100681187);
			GameplayMenu.NativeMethodInfoPtr_Exit_Public_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenu>.NativeClassPtr, 100681188);
			GameplayMenu.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenu>.NativeClassPtr, 100681189);
			GameplayMenu.NativeMethodInfoPtr_SetScreen_Public_Void_EGameplayScreen_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenu>.NativeClassPtr, 100681190);
			GameplayMenu.NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenu>.NativeClassPtr, 100681191);
			GameplayMenu.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenu>.NativeClassPtr, 100681192);
			GameplayMenu.NativeMethodInfoPtr_Method_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenu>.NativeClassPtr, 100681193);
			GameplayMenu.NativeMethodInfoPtr_Method_Private_IEnumerator_Boolean_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenu>.NativeClassPtr, 100681194);
		}

		// Token: 0x17002B84 RID: 11140
		// (get) Token: 0x06008F3A RID: 36666 RVA: 0x00258018 File Offset: 0x00256218
		// (set) Token: 0x06008F3B RID: 36667 RVA: 0x00258054 File Offset: 0x00256254
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GameplayMenu.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 40119, RefRangeEnd = 40138, XrefRangeStart = 40119, XrefRangeEnd = 40138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenu.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002B85 RID: 11141
		// (get) Token: 0x06008F3C RID: 36668 RVA: 0x00258094 File Offset: 0x00256294
		public unsafe bool CharacterScreenEnabled
		{
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 31612, RefRangeEnd = 31633, XrefRangeStart = 31612, XrefRangeEnd = 31633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GameplayMenu.NativeMethodInfoPtr_get_CharacterScreenEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17002B86 RID: 11142
		// (get) Token: 0x06008F3D RID: 36669 RVA: 0x002580D0 File Offset: 0x002562D0
		// (set) Token: 0x06008F3E RID: 36670 RVA: 0x0025810C File Offset: 0x0025630C
		public unsafe GameplayMenu.EGameplayScreen CurrentScreen
		{
			[CallerCount(26)]
			[CachedScanResults(RefRangeStart = 84444, RefRangeEnd = 84470, XrefRangeStart = 84444, XrefRangeEnd = 84470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GameplayMenu.NativeMethodInfoPtr_get_CurrentScreen_Public_get_EGameplayScreen_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 183194, RefRangeEnd = 183195, XrefRangeStart = 183194, XrefRangeEnd = 183195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenu.NativeMethodInfoPtr_set_CurrentScreen_Protected_set_Void_EGameplayScreen_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06008F3F RID: 36671 RVA: 0x0025814C File Offset: 0x0025634C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261311, XrefRangeEnd = 261333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameplayMenu.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008F40 RID: 36672 RVA: 0x00258188 File Offset: 0x00256388
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261333, XrefRangeEnd = 261344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction exit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(exit);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenu.NativeMethodInfoPtr_Exit_Public_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008F41 RID: 36673 RVA: 0x002581CC File Offset: 0x002563CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261344, XrefRangeEnd = 261393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameplayMenu.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008F42 RID: 36674 RVA: 0x00258208 File Offset: 0x00256408
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 261426, RefRangeEnd = 261429, XrefRangeStart = 261393, XrefRangeEnd = 261426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetScreen(GameplayMenu.EGameplayScreen screen)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref screen;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenu.NativeMethodInfoPtr_SetScreen_Public_Void_EGameplayScreen_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008F43 RID: 36675 RVA: 0x00258248 File Offset: 0x00256448
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 261556, RefRangeEnd = 261562, XrefRangeStart = 261429, XrefRangeEnd = 261556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsOpen(bool open)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref open;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenu.NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008F44 RID: 36676 RVA: 0x00258288 File Offset: 0x00256488
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261562, XrefRangeEnd = 261565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameplayMenu() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameplayMenu>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenu.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008F45 RID: 36677 RVA: 0x002582C4 File Offset: 0x002564C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 261578, RefRangeEnd = 261580, XrefRangeStart = 261565, XrefRangeEnd = 261578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenu.NativeMethodInfoPtr_Method_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008F46 RID: 36678 RVA: 0x002582F8 File Offset: 0x002564F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261580, XrefRangeEnd = 261585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_Boolean_PDM_0(bool open)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref open;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenu.NativeMethodInfoPtr_Method_Private_IEnumerator_Boolean_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x06008F47 RID: 36679 RVA: 0x00044701 File Offset: 0x00042901
		public GameplayMenu(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002B79 RID: 11129
		// (get) Token: 0x06008F48 RID: 36680 RVA: 0x00258344 File Offset: 0x00256544
		// (set) Token: 0x06008F49 RID: 36681 RVA: 0x0004470A File Offset: 0x0004290A
		public unsafe static float OpenVerticalOffset
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(GameplayMenu.NativeFieldInfoPtr_OpenVerticalOffset, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GameplayMenu.NativeFieldInfoPtr_OpenVerticalOffset, (void*)(&value));
			}
		}

		// Token: 0x17002B7A RID: 11130
		// (get) Token: 0x06008F4A RID: 36682 RVA: 0x00258360 File Offset: 0x00256560
		// (set) Token: 0x06008F4B RID: 36683 RVA: 0x00044718 File Offset: 0x00042918
		public unsafe static float ClosedVerticalOffset
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(GameplayMenu.NativeFieldInfoPtr_ClosedVerticalOffset, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GameplayMenu.NativeFieldInfoPtr_ClosedVerticalOffset, (void*)(&value));
			}
		}

		// Token: 0x17002B7B RID: 11131
		// (get) Token: 0x06008F4C RID: 36684 RVA: 0x0025837C File Offset: 0x0025657C
		// (set) Token: 0x06008F4D RID: 36685 RVA: 0x00044726 File Offset: 0x00042926
		public unsafe static float OpenTime
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(GameplayMenu.NativeFieldInfoPtr_OpenTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GameplayMenu.NativeFieldInfoPtr_OpenTime, (void*)(&value));
			}
		}

		// Token: 0x17002B7C RID: 11132
		// (get) Token: 0x06008F4E RID: 36686 RVA: 0x00258398 File Offset: 0x00256598
		// (set) Token: 0x06008F4F RID: 36687 RVA: 0x00044734 File Offset: 0x00042934
		public unsafe static float SlideTime
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(GameplayMenu.NativeFieldInfoPtr_SlideTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GameplayMenu.NativeFieldInfoPtr_SlideTime, (void*)(&value));
			}
		}

		// Token: 0x17002B7D RID: 11133
		// (get) Token: 0x06008F50 RID: 36688 RVA: 0x002583B4 File Offset: 0x002565B4
		// (set) Token: 0x06008F51 RID: 36689 RVA: 0x00044742 File Offset: 0x00042942
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002B7E RID: 11134
		// (get) Token: 0x06008F52 RID: 36690 RVA: 0x002583DC File Offset: 0x002565DC
		// (set) Token: 0x06008F53 RID: 36691 RVA: 0x0004475D File Offset: 0x0004295D
		public unsafe GameplayMenu.EGameplayScreen _CurrentScreen_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.NativeFieldInfoPtr__CurrentScreen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.NativeFieldInfoPtr__CurrentScreen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002B7F RID: 11135
		// (get) Token: 0x06008F54 RID: 36692 RVA: 0x00258404 File Offset: 0x00256604
		// (set) Token: 0x06008F55 RID: 36693 RVA: 0x00044778 File Offset: 0x00042978
		public unsafe Camera OverlayCamera
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.NativeFieldInfoPtr_OverlayCamera);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.NativeFieldInfoPtr_OverlayCamera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B80 RID: 11136
		// (get) Token: 0x06008F56 RID: 36694 RVA: 0x00258434 File Offset: 0x00256634
		// (set) Token: 0x06008F57 RID: 36695 RVA: 0x00044797 File Offset: 0x00042997
		public unsafe Light OverlayLight
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.NativeFieldInfoPtr_OverlayLight);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Light>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.NativeFieldInfoPtr_OverlayLight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B81 RID: 11137
		// (get) Token: 0x06008F58 RID: 36696 RVA: 0x00258464 File Offset: 0x00256664
		// (set) Token: 0x06008F59 RID: 36697 RVA: 0x000447B6 File Offset: 0x000429B6
		public unsafe float ContainerOffset_PhoneScreen
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.NativeFieldInfoPtr_ContainerOffset_PhoneScreen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.NativeFieldInfoPtr_ContainerOffset_PhoneScreen)) = value;
			}
		}

		// Token: 0x17002B82 RID: 11138
		// (get) Token: 0x06008F5A RID: 36698 RVA: 0x0025848C File Offset: 0x0025668C
		// (set) Token: 0x06008F5B RID: 36699 RVA: 0x000447D1 File Offset: 0x000429D1
		public unsafe Coroutine openCloseRoutine
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.NativeFieldInfoPtr_openCloseRoutine);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.NativeFieldInfoPtr_openCloseRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B83 RID: 11139
		// (get) Token: 0x06008F5C RID: 36700 RVA: 0x002584BC File Offset: 0x002566BC
		// (set) Token: 0x06008F5D RID: 36701 RVA: 0x000447F0 File Offset: 0x000429F0
		public unsafe Coroutine screenChangeRoutine
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.NativeFieldInfoPtr_screenChangeRoutine);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.NativeFieldInfoPtr_screenChangeRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006114 RID: 24852
		private static readonly System.IntPtr NativeFieldInfoPtr_OpenVerticalOffset;

		// Token: 0x04006115 RID: 24853
		private static readonly System.IntPtr NativeFieldInfoPtr_ClosedVerticalOffset;

		// Token: 0x04006116 RID: 24854
		private static readonly System.IntPtr NativeFieldInfoPtr_OpenTime;

		// Token: 0x04006117 RID: 24855
		private static readonly System.IntPtr NativeFieldInfoPtr_SlideTime;

		// Token: 0x04006118 RID: 24856
		private static readonly System.IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04006119 RID: 24857
		private static readonly System.IntPtr NativeFieldInfoPtr__CurrentScreen_k__BackingField;

		// Token: 0x0400611A RID: 24858
		private static readonly System.IntPtr NativeFieldInfoPtr_OverlayCamera;

		// Token: 0x0400611B RID: 24859
		private static readonly System.IntPtr NativeFieldInfoPtr_OverlayLight;

		// Token: 0x0400611C RID: 24860
		private static readonly System.IntPtr NativeFieldInfoPtr_ContainerOffset_PhoneScreen;

		// Token: 0x0400611D RID: 24861
		private static readonly System.IntPtr NativeFieldInfoPtr_openCloseRoutine;

		// Token: 0x0400611E RID: 24862
		private static readonly System.IntPtr NativeFieldInfoPtr_screenChangeRoutine;

		// Token: 0x0400611F RID: 24863
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04006120 RID: 24864
		private static readonly System.IntPtr NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0;

		// Token: 0x04006121 RID: 24865
		private static readonly System.IntPtr NativeMethodInfoPtr_get_CharacterScreenEnabled_Public_get_Boolean_0;

		// Token: 0x04006122 RID: 24866
		private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentScreen_Public_get_EGameplayScreen_0;

		// Token: 0x04006123 RID: 24867
		private static readonly System.IntPtr NativeMethodInfoPtr_set_CurrentScreen_Protected_set_Void_EGameplayScreen_0;

		// Token: 0x04006124 RID: 24868
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04006125 RID: 24869
		private static readonly System.IntPtr NativeMethodInfoPtr_Exit_Public_Void_ExitAction_0;

		// Token: 0x04006126 RID: 24870
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04006127 RID: 24871
		private static readonly System.IntPtr NativeMethodInfoPtr_SetScreen_Public_Void_EGameplayScreen_0;

		// Token: 0x04006128 RID: 24872
		private static readonly System.IntPtr NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_0;

		// Token: 0x04006129 RID: 24873
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400612A RID: 24874
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_Void_0;

		// Token: 0x0400612B RID: 24875
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_Boolean_PDM_0;

		// Token: 0x02000B6E RID: 2926
		[OriginalName("Assembly-CSharp.dll", "", "EGameplayScreen")]
		public enum EGameplayScreen
		{
			// Token: 0x04009452 RID: 37970
			Phone,
			// Token: 0x04009453 RID: 37971
			Character
		}

		// Token: 0x02000B6F RID: 2927
		[ObfuscatedName("ScheduleOne.UI.GameplayMenu+<<SetIsOpen>g__SetIsOpenRoutine|24_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600DC81 RID: 56449 RVA: 0x00349380 File Offset: 0x00347580
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique()
			{
				Il2CppClassPointerStore<GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameplayMenu>.NativeClassPtr, "<<SetIsOpen>g__SetIsOpenRoutine|24_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique>.NativeClassPtr);
				GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique>.NativeClassPtr, "<>1__state");
				GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique>.NativeClassPtr, "<>2__current");
				GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique.NativeFieldInfoPtr_open = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique>.NativeClassPtr, "open");
				GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique>.NativeClassPtr, "<>4__this");
				GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique.NativeFieldInfoPtr__adjustedLerpTime_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique>.NativeClassPtr, "<adjustedLerpTime>5__2");
				GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique.NativeFieldInfoPtr__startVert_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique>.NativeClassPtr, "<startVert>5__3");
				GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique.NativeFieldInfoPtr__endVert_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique>.NativeClassPtr, "<endVert>5__4");
				GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique.NativeFieldInfoPtr__i_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique>.NativeClassPtr, "<i>5__5");
				GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique>.NativeClassPtr, 100681195);
				GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique>.NativeClassPtr, 100681196);
				GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique>.NativeClassPtr, 100681197);
				GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique>.NativeClassPtr, 100681198);
				GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique>.NativeClassPtr, 100681199);
				GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique>.NativeClassPtr, 100681200);
			}

			// Token: 0x0600DC82 RID: 56450 RVA: 0x003494C4 File Offset: 0x003476C4
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DC83 RID: 56451 RVA: 0x0034950C File Offset: 0x0034770C
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DC84 RID: 56452 RVA: 0x00349540 File Offset: 0x00347740
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261228, XrefRangeEnd = 261263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x1700440F RID: 17423
			// (get) Token: 0x0600DC85 RID: 56453 RVA: 0x0034957C File Offset: 0x0034777C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600DC86 RID: 56454 RVA: 0x003495BC File Offset: 0x003477BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261263, XrefRangeEnd = 261268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x17004410 RID: 17424
			// (get) Token: 0x0600DC87 RID: 56455 RVA: 0x003495F0 File Offset: 0x003477F0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600DC88 RID: 56456 RVA: 0x0006B04A File Offset: 0x0006924A
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004407 RID: 17415
			// (get) Token: 0x0600DC89 RID: 56457 RVA: 0x00349630 File Offset: 0x00347830
			// (set) Token: 0x0600DC8A RID: 56458 RVA: 0x0006B053 File Offset: 0x00069253
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004408 RID: 17416
			// (get) Token: 0x0600DC8B RID: 56459 RVA: 0x00349658 File Offset: 0x00347858
			// (set) Token: 0x0600DC8C RID: 56460 RVA: 0x0006B06E File Offset: 0x0006926E
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004409 RID: 17417
			// (get) Token: 0x0600DC8D RID: 56461 RVA: 0x00349688 File Offset: 0x00347888
			// (set) Token: 0x0600DC8E RID: 56462 RVA: 0x0006B08D File Offset: 0x0006928D
			public unsafe bool open
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique.NativeFieldInfoPtr_open);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique.NativeFieldInfoPtr_open)) = value;
				}
			}

			// Token: 0x1700440A RID: 17418
			// (get) Token: 0x0600DC8F RID: 56463 RVA: 0x003496B0 File Offset: 0x003478B0
			// (set) Token: 0x0600DC90 RID: 56464 RVA: 0x0006B0A8 File Offset: 0x000692A8
			public unsafe GameplayMenu __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameplayMenu>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700440B RID: 17419
			// (get) Token: 0x0600DC91 RID: 56465 RVA: 0x003496E0 File Offset: 0x003478E0
			// (set) Token: 0x0600DC92 RID: 56466 RVA: 0x0006B0C7 File Offset: 0x000692C7
			public unsafe float _adjustedLerpTime_5__2
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique.NativeFieldInfoPtr__adjustedLerpTime_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique.NativeFieldInfoPtr__adjustedLerpTime_5__2)) = value;
				}
			}

			// Token: 0x1700440C RID: 17420
			// (get) Token: 0x0600DC93 RID: 56467 RVA: 0x00349708 File Offset: 0x00347908
			// (set) Token: 0x0600DC94 RID: 56468 RVA: 0x0006B0E2 File Offset: 0x000692E2
			public unsafe float _startVert_5__3
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique.NativeFieldInfoPtr__startVert_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique.NativeFieldInfoPtr__startVert_5__3)) = value;
				}
			}

			// Token: 0x1700440D RID: 17421
			// (get) Token: 0x0600DC95 RID: 56469 RVA: 0x00349730 File Offset: 0x00347930
			// (set) Token: 0x0600DC96 RID: 56470 RVA: 0x0006B0FD File Offset: 0x000692FD
			public unsafe float _endVert_5__4
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique.NativeFieldInfoPtr__endVert_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique.NativeFieldInfoPtr__endVert_5__4)) = value;
				}
			}

			// Token: 0x1700440E RID: 17422
			// (get) Token: 0x0600DC97 RID: 56471 RVA: 0x00349758 File Offset: 0x00347958
			// (set) Token: 0x0600DC98 RID: 56472 RVA: 0x0006B118 File Offset: 0x00069318
			public unsafe float _i_5__5
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique.NativeFieldInfoPtr__i_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique.NativeFieldInfoPtr__i_5__5)) = value;
				}
			}

			// Token: 0x04009454 RID: 37972
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009455 RID: 37973
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009456 RID: 37974
			private static readonly System.IntPtr NativeFieldInfoPtr_open;

			// Token: 0x04009457 RID: 37975
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009458 RID: 37976
			private static readonly System.IntPtr NativeFieldInfoPtr__adjustedLerpTime_5__2;

			// Token: 0x04009459 RID: 37977
			private static readonly System.IntPtr NativeFieldInfoPtr__startVert_5__3;

			// Token: 0x0400945A RID: 37978
			private static readonly System.IntPtr NativeFieldInfoPtr__endVert_5__4;

			// Token: 0x0400945B RID: 37979
			private static readonly System.IntPtr NativeFieldInfoPtr__i_5__5;

			// Token: 0x0400945C RID: 37980
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400945D RID: 37981
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400945E RID: 37982
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400945F RID: 37983
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009460 RID: 37984
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009461 RID: 37985
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000B70 RID: 2928
		[ObfuscatedName("ScheduleOne.UI.GameplayMenu+<>c__DisplayClass23_0")]
		public sealed class __c__DisplayClass23_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DC99 RID: 56473 RVA: 0x00349780 File Offset: 0x00347980
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass23_0()
			{
				Il2CppClassPointerStore<GameplayMenu.__c__DisplayClass23_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameplayMenu>.NativeClassPtr, "<>c__DisplayClass23_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameplayMenu.__c__DisplayClass23_0>.NativeClassPtr);
				GameplayMenu.__c__DisplayClass23_0.NativeFieldInfoPtr_screen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenu.__c__DisplayClass23_0>.NativeClassPtr, "screen");
				GameplayMenu.__c__DisplayClass23_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenu.__c__DisplayClass23_0>.NativeClassPtr, "<>4__this");
				GameplayMenu.__c__DisplayClass23_0.NativeFieldInfoPtr_previousScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenu.__c__DisplayClass23_0>.NativeClassPtr, "previousScreen");
				GameplayMenu.__c__DisplayClass23_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenu.__c__DisplayClass23_0>.NativeClassPtr, 100681201);
				GameplayMenu.__c__DisplayClass23_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenu.__c__DisplayClass23_0>.NativeClassPtr, 100681202);
			}

			// Token: 0x0600DC9A RID: 56474 RVA: 0x00349810 File Offset: 0x00347A10
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass23_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameplayMenu.__c__DisplayClass23_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenu.__c__DisplayClass23_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DC9B RID: 56475 RVA: 0x0034984C File Offset: 0x00347A4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261306, XrefRangeEnd = 261311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenu.__c__DisplayClass23_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}

			// Token: 0x0600DC9C RID: 56476 RVA: 0x0006B133 File Offset: 0x00069333
			public __c__DisplayClass23_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004411 RID: 17425
			// (get) Token: 0x0600DC9D RID: 56477 RVA: 0x0034988C File Offset: 0x00347A8C
			// (set) Token: 0x0600DC9E RID: 56478 RVA: 0x0006B13C File Offset: 0x0006933C
			public unsafe GameplayMenu.EGameplayScreen screen
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.__c__DisplayClass23_0.NativeFieldInfoPtr_screen);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.__c__DisplayClass23_0.NativeFieldInfoPtr_screen)) = value;
				}
			}

			// Token: 0x17004412 RID: 17426
			// (get) Token: 0x0600DC9F RID: 56479 RVA: 0x003498B4 File Offset: 0x00347AB4
			// (set) Token: 0x0600DCA0 RID: 56480 RVA: 0x0006B157 File Offset: 0x00069357
			public unsafe GameplayMenu __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.__c__DisplayClass23_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameplayMenu>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.__c__DisplayClass23_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004413 RID: 17427
			// (get) Token: 0x0600DCA1 RID: 56481 RVA: 0x003498E4 File Offset: 0x00347AE4
			// (set) Token: 0x0600DCA2 RID: 56482 RVA: 0x0006B176 File Offset: 0x00069376
			public unsafe GameplayMenu.EGameplayScreen previousScreen
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.__c__DisplayClass23_0.NativeFieldInfoPtr_previousScreen);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.__c__DisplayClass23_0.NativeFieldInfoPtr_previousScreen)) = value;
				}
			}

			// Token: 0x04009462 RID: 37986
			private static readonly System.IntPtr NativeFieldInfoPtr_screen;

			// Token: 0x04009463 RID: 37987
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009464 RID: 37988
			private static readonly System.IntPtr NativeFieldInfoPtr_previousScreen;

			// Token: 0x04009465 RID: 37989
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009466 RID: 37990
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000CCD RID: 3277
			[ObfuscatedName("ScheduleOne.UI.GameplayMenu+<>c__DisplayClass23_0+<<SetScreen>g__ScreenChange|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600EADF RID: 60127 RVA: 0x00372860 File Offset: 0x00370A60
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique()
				{
					Il2CppClassPointerStore<GameplayMenu.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameplayMenu.__c__DisplayClass23_0>.NativeClassPtr, "<<SetScreen>g__ScreenChange|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameplayMenu.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr);
					GameplayMenu.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenu.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, "<>1__state");
					GameplayMenu.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenu.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, "<>2__current");
					GameplayMenu.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenu.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, "<>4__this");
					GameplayMenu.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__endXPos_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenu.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, "<endXPos>5__2");
					GameplayMenu.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__startXPos_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenu.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, "<startXPos>5__3");
					GameplayMenu.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__t_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenu.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, "<t>5__4");
					GameplayMenu.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenu.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, 100681203);
					GameplayMenu.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenu.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, 100681204);
					GameplayMenu.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenu.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, 100681205);
					GameplayMenu.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenu.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, 100681206);
					GameplayMenu.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenu.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, 100681207);
					GameplayMenu.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenu.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, 100681208);
				}

				// Token: 0x0600EAE0 RID: 60128 RVA: 0x0037297C File Offset: 0x00370B7C
				[CallerCount(54)]
				[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameplayMenu.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr))
				{
					System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
					*ptr = ref <>1__state;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenu.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600EAE1 RID: 60129 RVA: 0x003729C4 File Offset: 0x00370BC4
				[CallerCount(14558)]
				[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenu.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600EAE2 RID: 60130 RVA: 0x003729F8 File Offset: 0x00370BF8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261268, XrefRangeEnd = 261301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GameplayMenu.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}

				// Token: 0x170048B6 RID: 18614
				// (get) Token: 0x0600EAE3 RID: 60131 RVA: 0x00372A34 File Offset: 0x00370C34
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenu.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600EAE4 RID: 60132 RVA: 0x00372A74 File Offset: 0x00370C74
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261301, XrefRangeEnd = 261306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenu.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x170048B7 RID: 18615
				// (get) Token: 0x0600EAE5 RID: 60133 RVA: 0x00372AA8 File Offset: 0x00370CA8
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenu.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600EAE6 RID: 60134 RVA: 0x000723C6 File Offset: 0x000705C6
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique(System.IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170048B0 RID: 18608
				// (get) Token: 0x0600EAE7 RID: 60135 RVA: 0x00372AE8 File Offset: 0x00370CE8
				// (set) Token: 0x0600EAE8 RID: 60136 RVA: 0x000723CF File Offset: 0x000705CF
				public unsafe int __1__state
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170048B1 RID: 18609
				// (get) Token: 0x0600EAE9 RID: 60137 RVA: 0x00372B10 File Offset: 0x00370D10
				// (set) Token: 0x0600EAEA RID: 60138 RVA: 0x000723EA File Offset: 0x000705EA
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___2__current);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170048B2 RID: 18610
				// (get) Token: 0x0600EAEB RID: 60139 RVA: 0x00372B40 File Offset: 0x00370D40
				// (set) Token: 0x0600EAEC RID: 60140 RVA: 0x00072409 File Offset: 0x00070609
				public unsafe GameplayMenu.__c__DisplayClass23_0 __4__this
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___4__this);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameplayMenu.__c__DisplayClass23_0>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170048B3 RID: 18611
				// (get) Token: 0x0600EAED RID: 60141 RVA: 0x00372B70 File Offset: 0x00370D70
				// (set) Token: 0x0600EAEE RID: 60142 RVA: 0x00072428 File Offset: 0x00070628
				public unsafe float _endXPos_5__2
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__endXPos_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__endXPos_5__2)) = value;
					}
				}

				// Token: 0x170048B4 RID: 18612
				// (get) Token: 0x0600EAEF RID: 60143 RVA: 0x00372B98 File Offset: 0x00370D98
				// (set) Token: 0x0600EAF0 RID: 60144 RVA: 0x00072443 File Offset: 0x00070643
				public unsafe float _startXPos_5__3
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__startXPos_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__startXPos_5__3)) = value;
					}
				}

				// Token: 0x170048B5 RID: 18613
				// (get) Token: 0x0600EAF1 RID: 60145 RVA: 0x00372BC0 File Offset: 0x00370DC0
				// (set) Token: 0x0600EAF2 RID: 60146 RVA: 0x0007245E File Offset: 0x0007065E
				public unsafe float _t_5__4
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__t_5__4);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__t_5__4)) = value;
					}
				}

				// Token: 0x04009D1B RID: 40219
				private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009D1C RID: 40220
				private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009D1D RID: 40221
				private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009D1E RID: 40222
				private static readonly System.IntPtr NativeFieldInfoPtr__endXPos_5__2;

				// Token: 0x04009D1F RID: 40223
				private static readonly System.IntPtr NativeFieldInfoPtr__startXPos_5__3;

				// Token: 0x04009D20 RID: 40224
				private static readonly System.IntPtr NativeFieldInfoPtr__t_5__4;

				// Token: 0x04009D21 RID: 40225
				private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009D22 RID: 40226
				private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009D23 RID: 40227
				private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009D24 RID: 40228
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009D25 RID: 40229
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009D26 RID: 40230
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
