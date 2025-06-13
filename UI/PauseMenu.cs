using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.UI.MainMenu;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000673 RID: 1651
	public class PauseMenu : Singleton<PauseMenu>
	{
		// Token: 0x0600918E RID: 37262 RVA: 0x0025E9B4 File Offset: 0x0025CBB4
		// Note: this type is marked as 'beforefieldinit'.
		static PauseMenu()
		{
			Il2CppClassPointerStore<PauseMenu>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "PauseMenu");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr);
			PauseMenu.NativeFieldInfoPtr__IsPaused_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, "<IsPaused>k__BackingField");
			PauseMenu.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, "Canvas");
			PauseMenu.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, "Container");
			PauseMenu.NativeFieldInfoPtr_Screen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, "Screen");
			PauseMenu.NativeFieldInfoPtr_FeedbackForm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, "FeedbackForm");
			PauseMenu.NativeFieldInfoPtr_noActiveUIElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, "noActiveUIElements");
			PauseMenu.NativeFieldInfoPtr_justPaused = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, "justPaused");
			PauseMenu.NativeFieldInfoPtr_justResumed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, "justResumed");
			PauseMenu.NativeFieldInfoPtr_couldLook = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, "couldLook");
			PauseMenu.NativeFieldInfoPtr_lockedMouse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, "lockedMouse");
			PauseMenu.NativeFieldInfoPtr_crosshairVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, "crosshairVisible");
			PauseMenu.NativeFieldInfoPtr_hudVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, "hudVisible");
			PauseMenu.NativeFieldInfoPtr_onPause = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, "onPause");
			PauseMenu.NativeFieldInfoPtr_onResume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, "onResume");
			PauseMenu.NativeMethodInfoPtr_get_IsPaused_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, 100681450);
			PauseMenu.NativeMethodInfoPtr_set_IsPaused_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, 100681451);
			PauseMenu.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, 100681452);
			PauseMenu.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, 100681453);
			PauseMenu.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, 100681454);
			PauseMenu.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, 100681455);
			PauseMenu.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, 100681456);
			PauseMenu.NativeMethodInfoPtr_Pause_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, 100681457);
			PauseMenu.NativeMethodInfoPtr_Resume_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, 100681458);
			PauseMenu.NativeMethodInfoPtr_StuckButtonClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, 100681459);
			PauseMenu.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, 100681460);
		}

		// Token: 0x17002C5B RID: 11355
		// (get) Token: 0x0600918F RID: 37263 RVA: 0x0025EBD8 File Offset: 0x0025CDD8
		// (set) Token: 0x06009190 RID: 37264 RVA: 0x0025EC14 File Offset: 0x0025CE14
		public unsafe bool IsPaused
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PauseMenu.NativeMethodInfoPtr_get_IsPaused_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PauseMenu.NativeMethodInfoPtr_set_IsPaused_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06009191 RID: 37265 RVA: 0x0025EC54 File Offset: 0x0025CE54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264073, XrefRangeEnd = 264086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PauseMenu.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009192 RID: 37266 RVA: 0x0025EC90 File Offset: 0x0025CE90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264086, XrefRangeEnd = 264093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PauseMenu.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009193 RID: 37267 RVA: 0x0025ECCC File Offset: 0x0025CECC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264093, XrefRangeEnd = 264098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PauseMenu.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009194 RID: 37268 RVA: 0x0025ED10 File Offset: 0x0025CF10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264098, XrefRangeEnd = 264101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PauseMenu.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009195 RID: 37269 RVA: 0x0025ED44 File Offset: 0x0025CF44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264101, XrefRangeEnd = 264109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PauseMenu.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009196 RID: 37270 RVA: 0x0025ED78 File Offset: 0x0025CF78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 264171, RefRangeEnd = 264172, XrefRangeStart = 264109, XrefRangeEnd = 264171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Pause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PauseMenu.NativeMethodInfoPtr_Pause_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009197 RID: 37271 RVA: 0x0025EDAC File Offset: 0x0025CFAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 264228, RefRangeEnd = 264229, XrefRangeStart = 264172, XrefRangeEnd = 264228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Resume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PauseMenu.NativeMethodInfoPtr_Resume_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009198 RID: 37272 RVA: 0x0025EDE0 File Offset: 0x0025CFE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264229, XrefRangeEnd = 264236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StuckButtonClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PauseMenu.NativeMethodInfoPtr_StuckButtonClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009199 RID: 37273 RVA: 0x0025EE14 File Offset: 0x0025D014
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264236, XrefRangeEnd = 264239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PauseMenu() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PauseMenu.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600919A RID: 37274 RVA: 0x00045E10 File Offset: 0x00044010
		public PauseMenu(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002C4D RID: 11341
		// (get) Token: 0x0600919B RID: 37275 RVA: 0x0025EE50 File Offset: 0x0025D050
		// (set) Token: 0x0600919C RID: 37276 RVA: 0x00045E19 File Offset: 0x00044019
		public unsafe bool _IsPaused_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr__IsPaused_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr__IsPaused_k__BackingField)) = value;
			}
		}

		// Token: 0x17002C4E RID: 11342
		// (get) Token: 0x0600919D RID: 37277 RVA: 0x0025EE78 File Offset: 0x0025D078
		// (set) Token: 0x0600919E RID: 37278 RVA: 0x00045E34 File Offset: 0x00044034
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C4F RID: 11343
		// (get) Token: 0x0600919F RID: 37279 RVA: 0x0025EEA8 File Offset: 0x0025D0A8
		// (set) Token: 0x060091A0 RID: 37280 RVA: 0x00045E53 File Offset: 0x00044053
		public unsafe RectTransform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C50 RID: 11344
		// (get) Token: 0x060091A1 RID: 37281 RVA: 0x0025EED8 File Offset: 0x0025D0D8
		// (set) Token: 0x060091A2 RID: 37282 RVA: 0x00045E72 File Offset: 0x00044072
		public unsafe MainMenuScreen Screen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_Screen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MainMenuScreen>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_Screen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C51 RID: 11345
		// (get) Token: 0x060091A3 RID: 37283 RVA: 0x0025EF08 File Offset: 0x0025D108
		// (set) Token: 0x060091A4 RID: 37284 RVA: 0x00045E91 File Offset: 0x00044091
		public unsafe FeedbackForm FeedbackForm
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_FeedbackForm);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FeedbackForm>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_FeedbackForm), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C52 RID: 11346
		// (get) Token: 0x060091A5 RID: 37285 RVA: 0x0025EF38 File Offset: 0x0025D138
		// (set) Token: 0x060091A6 RID: 37286 RVA: 0x00045EB0 File Offset: 0x000440B0
		public unsafe bool noActiveUIElements
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_noActiveUIElements);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_noActiveUIElements)) = value;
			}
		}

		// Token: 0x17002C53 RID: 11347
		// (get) Token: 0x060091A7 RID: 37287 RVA: 0x0025EF60 File Offset: 0x0025D160
		// (set) Token: 0x060091A8 RID: 37288 RVA: 0x00045ECB File Offset: 0x000440CB
		public unsafe bool justPaused
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_justPaused);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_justPaused)) = value;
			}
		}

		// Token: 0x17002C54 RID: 11348
		// (get) Token: 0x060091A9 RID: 37289 RVA: 0x0025EF88 File Offset: 0x0025D188
		// (set) Token: 0x060091AA RID: 37290 RVA: 0x00045EE6 File Offset: 0x000440E6
		public unsafe bool justResumed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_justResumed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_justResumed)) = value;
			}
		}

		// Token: 0x17002C55 RID: 11349
		// (get) Token: 0x060091AB RID: 37291 RVA: 0x0025EFB0 File Offset: 0x0025D1B0
		// (set) Token: 0x060091AC RID: 37292 RVA: 0x00045F01 File Offset: 0x00044101
		public unsafe bool couldLook
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_couldLook);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_couldLook)) = value;
			}
		}

		// Token: 0x17002C56 RID: 11350
		// (get) Token: 0x060091AD RID: 37293 RVA: 0x0025EFD8 File Offset: 0x0025D1D8
		// (set) Token: 0x060091AE RID: 37294 RVA: 0x00045F1C File Offset: 0x0004411C
		public unsafe bool lockedMouse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_lockedMouse);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_lockedMouse)) = value;
			}
		}

		// Token: 0x17002C57 RID: 11351
		// (get) Token: 0x060091AF RID: 37295 RVA: 0x0025F000 File Offset: 0x0025D200
		// (set) Token: 0x060091B0 RID: 37296 RVA: 0x00045F37 File Offset: 0x00044137
		public unsafe bool crosshairVisible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_crosshairVisible);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_crosshairVisible)) = value;
			}
		}

		// Token: 0x17002C58 RID: 11352
		// (get) Token: 0x060091B1 RID: 37297 RVA: 0x0025F028 File Offset: 0x0025D228
		// (set) Token: 0x060091B2 RID: 37298 RVA: 0x00045F52 File Offset: 0x00044152
		public unsafe bool hudVisible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_hudVisible);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_hudVisible)) = value;
			}
		}

		// Token: 0x17002C59 RID: 11353
		// (get) Token: 0x060091B3 RID: 37299 RVA: 0x0025F050 File Offset: 0x0025D250
		// (set) Token: 0x060091B4 RID: 37300 RVA: 0x00045F6D File Offset: 0x0004416D
		public unsafe UnityEvent onPause
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_onPause);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_onPause), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C5A RID: 11354
		// (get) Token: 0x060091B5 RID: 37301 RVA: 0x0025F080 File Offset: 0x0025D280
		// (set) Token: 0x060091B6 RID: 37302 RVA: 0x00045F8C File Offset: 0x0004418C
		public unsafe UnityEvent onResume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_onResume);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_onResume), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006282 RID: 25218
		private static readonly IntPtr NativeFieldInfoPtr__IsPaused_k__BackingField;

		// Token: 0x04006283 RID: 25219
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x04006284 RID: 25220
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04006285 RID: 25221
		private static readonly IntPtr NativeFieldInfoPtr_Screen;

		// Token: 0x04006286 RID: 25222
		private static readonly IntPtr NativeFieldInfoPtr_FeedbackForm;

		// Token: 0x04006287 RID: 25223
		private static readonly IntPtr NativeFieldInfoPtr_noActiveUIElements;

		// Token: 0x04006288 RID: 25224
		private static readonly IntPtr NativeFieldInfoPtr_justPaused;

		// Token: 0x04006289 RID: 25225
		private static readonly IntPtr NativeFieldInfoPtr_justResumed;

		// Token: 0x0400628A RID: 25226
		private static readonly IntPtr NativeFieldInfoPtr_couldLook;

		// Token: 0x0400628B RID: 25227
		private static readonly IntPtr NativeFieldInfoPtr_lockedMouse;

		// Token: 0x0400628C RID: 25228
		private static readonly IntPtr NativeFieldInfoPtr_crosshairVisible;

		// Token: 0x0400628D RID: 25229
		private static readonly IntPtr NativeFieldInfoPtr_hudVisible;

		// Token: 0x0400628E RID: 25230
		private static readonly IntPtr NativeFieldInfoPtr_onPause;

		// Token: 0x0400628F RID: 25231
		private static readonly IntPtr NativeFieldInfoPtr_onResume;

		// Token: 0x04006290 RID: 25232
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPaused_Public_get_Boolean_0;

		// Token: 0x04006291 RID: 25233
		private static readonly IntPtr NativeMethodInfoPtr_set_IsPaused_Protected_set_Void_Boolean_0;

		// Token: 0x04006292 RID: 25234
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04006293 RID: 25235
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04006294 RID: 25236
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x04006295 RID: 25237
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04006296 RID: 25238
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04006297 RID: 25239
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Public_Void_0;

		// Token: 0x04006298 RID: 25240
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Public_Void_0;

		// Token: 0x04006299 RID: 25241
		private static readonly IntPtr NativeMethodInfoPtr_StuckButtonClicked_Public_Void_0;

		// Token: 0x0400629A RID: 25242
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
