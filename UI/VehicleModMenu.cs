using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Vehicles;
using Il2CppScheduleOne.Vehicles.Modification;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000697 RID: 1687
	public class VehicleModMenu : Singleton<VehicleModMenu>
	{
		// Token: 0x06009583 RID: 38275 RVA: 0x0026A4B0 File Offset: 0x002686B0
		// Note: this type is marked as 'beforefieldinit'.
		static VehicleModMenu()
		{
			Il2CppClassPointerStore<VehicleModMenu>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "VehicleModMenu");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleModMenu>.NativeClassPtr);
			VehicleModMenu.NativeFieldInfoPtr_repaintCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleModMenu>.NativeClassPtr, "repaintCost");
			VehicleModMenu.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleModMenu>.NativeClassPtr, "<IsOpen>k__BackingField");
			VehicleModMenu.NativeFieldInfoPtr_canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleModMenu>.NativeClassPtr, "canvas");
			VehicleModMenu.NativeFieldInfoPtr_buttonContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleModMenu>.NativeClassPtr, "buttonContainer");
			VehicleModMenu.NativeFieldInfoPtr_tempIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleModMenu>.NativeClassPtr, "tempIndicator");
			VehicleModMenu.NativeFieldInfoPtr_permIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleModMenu>.NativeClassPtr, "permIndicator");
			VehicleModMenu.NativeFieldInfoPtr_confirmButton_Online = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleModMenu>.NativeClassPtr, "confirmButton_Online");
			VehicleModMenu.NativeFieldInfoPtr_confirmText_Online = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleModMenu>.NativeClassPtr, "confirmText_Online");
			VehicleModMenu.NativeFieldInfoPtr_CameraPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleModMenu>.NativeClassPtr, "CameraPosition");
			VehicleModMenu.NativeFieldInfoPtr_VehiclePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleModMenu>.NativeClassPtr, "VehiclePosition");
			VehicleModMenu.NativeFieldInfoPtr_buttonPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleModMenu>.NativeClassPtr, "buttonPrefab");
			VehicleModMenu.NativeFieldInfoPtr_onPaintPurchased = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleModMenu>.NativeClassPtr, "onPaintPurchased");
			VehicleModMenu.NativeFieldInfoPtr_currentVehicle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleModMenu>.NativeClassPtr, "currentVehicle");
			VehicleModMenu.NativeFieldInfoPtr_colorButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleModMenu>.NativeClassPtr, "colorButtons");
			VehicleModMenu.NativeFieldInfoPtr_colorToButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleModMenu>.NativeClassPtr, "colorToButton");
			VehicleModMenu.NativeFieldInfoPtr_selectedColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleModMenu>.NativeClassPtr, "selectedColor");
			VehicleModMenu.NativeFieldInfoPtr_openCloseRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleModMenu>.NativeClassPtr, "openCloseRoutine");
			VehicleModMenu.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleModMenu>.NativeClassPtr, 100681927);
			VehicleModMenu.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleModMenu>.NativeClassPtr, 100681928);
			VehicleModMenu.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleModMenu>.NativeClassPtr, 100681929);
			VehicleModMenu.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleModMenu>.NativeClassPtr, 100681930);
			VehicleModMenu.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleModMenu>.NativeClassPtr, 100681931);
			VehicleModMenu.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleModMenu>.NativeClassPtr, 100681932);
			VehicleModMenu.NativeMethodInfoPtr_Open_Public_Void_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleModMenu>.NativeClassPtr, 100681933);
			VehicleModMenu.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleModMenu>.NativeClassPtr, 100681934);
			VehicleModMenu.NativeMethodInfoPtr_ColorClicked_Public_Void_EVehicleColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleModMenu>.NativeClassPtr, 100681935);
			VehicleModMenu.NativeMethodInfoPtr_UpdateConfirmButton_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleModMenu>.NativeClassPtr, 100681936);
			VehicleModMenu.NativeMethodInfoPtr_RefreshSelectionIndicator_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleModMenu>.NativeClassPtr, 100681937);
			VehicleModMenu.NativeMethodInfoPtr_ConfirmButtonClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleModMenu>.NativeClassPtr, 100681938);
			VehicleModMenu.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleModMenu>.NativeClassPtr, 100681939);
			VehicleModMenu.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleModMenu>.NativeClassPtr, 100681941);
			VehicleModMenu.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleModMenu>.NativeClassPtr, 100681942);
		}

		// Token: 0x17002DAE RID: 11694
		// (get) Token: 0x06009584 RID: 38276 RVA: 0x0026A760 File Offset: 0x00268960
		// (set) Token: 0x06009585 RID: 38277 RVA: 0x0026A79C File Offset: 0x0026899C
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VehicleModMenu.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleModMenu.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06009586 RID: 38278 RVA: 0x0026A7DC File Offset: 0x002689DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269190, XrefRangeEnd = 269203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleModMenu.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009587 RID: 38279 RVA: 0x0026A818 File Offset: 0x00268A18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269203, XrefRangeEnd = 269275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleModMenu.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009588 RID: 38280 RVA: 0x0026A854 File Offset: 0x00268A54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269275, XrefRangeEnd = 269277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleModMenu.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009589 RID: 38281 RVA: 0x0026A898 File Offset: 0x00268A98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269277, XrefRangeEnd = 269278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleModMenu.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600958A RID: 38282 RVA: 0x0026A8D4 File Offset: 0x00268AD4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 269298, RefRangeEnd = 269300, XrefRangeStart = 269278, XrefRangeEnd = 269298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(LandVehicle vehicle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(vehicle);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleModMenu.NativeMethodInfoPtr_Open_Public_Void_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600958B RID: 38283 RVA: 0x0026A918 File Offset: 0x00268B18
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 269313, RefRangeEnd = 269317, XrefRangeStart = 269300, XrefRangeEnd = 269313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleModMenu.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600958C RID: 38284 RVA: 0x0026A94C File Offset: 0x00268B4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269317, XrefRangeEnd = 269320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ColorClicked(EVehicleColor col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref col;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleModMenu.NativeMethodInfoPtr_ColorClicked_Public_Void_EVehicleColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600958D RID: 38285 RVA: 0x0026A98C File Offset: 0x00268B8C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 269330, RefRangeEnd = 269334, XrefRangeStart = 269320, XrefRangeEnd = 269330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateConfirmButton()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleModMenu.NativeMethodInfoPtr_UpdateConfirmButton_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600958E RID: 38286 RVA: 0x0026A9C0 File Offset: 0x00268BC0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 269343, RefRangeEnd = 269347, XrefRangeStart = 269334, XrefRangeEnd = 269343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshSelectionIndicator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleModMenu.NativeMethodInfoPtr_RefreshSelectionIndicator_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600958F RID: 38287 RVA: 0x0026A9F4 File Offset: 0x00268BF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269347, XrefRangeEnd = 269368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfirmButtonClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleModMenu.NativeMethodInfoPtr_ConfirmButtonClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009590 RID: 38288 RVA: 0x0026AA28 File Offset: 0x00268C28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269368, XrefRangeEnd = 269385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleModMenu() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleModMenu>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleModMenu.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009591 RID: 38289 RVA: 0x0026AA64 File Offset: 0x00268C64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269385, XrefRangeEnd = 269390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleModMenu.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x06009592 RID: 38290 RVA: 0x0026AAA4 File Offset: 0x00268CA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269390, XrefRangeEnd = 269395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleModMenu.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x06009593 RID: 38291 RVA: 0x00048253 File Offset: 0x00046453
		public VehicleModMenu(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002D9D RID: 11677
		// (get) Token: 0x06009594 RID: 38292 RVA: 0x0026AAE4 File Offset: 0x00268CE4
		// (set) Token: 0x06009595 RID: 38293 RVA: 0x0004825C File Offset: 0x0004645C
		public unsafe static float repaintCost
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleModMenu.NativeFieldInfoPtr_repaintCost, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleModMenu.NativeFieldInfoPtr_repaintCost, (void*)(&value));
			}
		}

		// Token: 0x17002D9E RID: 11678
		// (get) Token: 0x06009596 RID: 38294 RVA: 0x0026AB00 File Offset: 0x00268D00
		// (set) Token: 0x06009597 RID: 38295 RVA: 0x0004826A File Offset: 0x0004646A
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModMenu.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModMenu.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002D9F RID: 11679
		// (get) Token: 0x06009598 RID: 38296 RVA: 0x0026AB28 File Offset: 0x00268D28
		// (set) Token: 0x06009599 RID: 38297 RVA: 0x00048285 File Offset: 0x00046485
		public unsafe Canvas canvas
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModMenu.NativeFieldInfoPtr_canvas);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModMenu.NativeFieldInfoPtr_canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DA0 RID: 11680
		// (get) Token: 0x0600959A RID: 38298 RVA: 0x0026AB58 File Offset: 0x00268D58
		// (set) Token: 0x0600959B RID: 38299 RVA: 0x000482A4 File Offset: 0x000464A4
		public unsafe RectTransform buttonContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModMenu.NativeFieldInfoPtr_buttonContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModMenu.NativeFieldInfoPtr_buttonContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DA1 RID: 11681
		// (get) Token: 0x0600959C RID: 38300 RVA: 0x0026AB88 File Offset: 0x00268D88
		// (set) Token: 0x0600959D RID: 38301 RVA: 0x000482C3 File Offset: 0x000464C3
		public unsafe RectTransform tempIndicator
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModMenu.NativeFieldInfoPtr_tempIndicator);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModMenu.NativeFieldInfoPtr_tempIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DA2 RID: 11682
		// (get) Token: 0x0600959E RID: 38302 RVA: 0x0026ABB8 File Offset: 0x00268DB8
		// (set) Token: 0x0600959F RID: 38303 RVA: 0x000482E2 File Offset: 0x000464E2
		public unsafe RectTransform permIndicator
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModMenu.NativeFieldInfoPtr_permIndicator);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModMenu.NativeFieldInfoPtr_permIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DA3 RID: 11683
		// (get) Token: 0x060095A0 RID: 38304 RVA: 0x0026ABE8 File Offset: 0x00268DE8
		// (set) Token: 0x060095A1 RID: 38305 RVA: 0x00048301 File Offset: 0x00046501
		public unsafe Button confirmButton_Online
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModMenu.NativeFieldInfoPtr_confirmButton_Online);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModMenu.NativeFieldInfoPtr_confirmButton_Online), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DA4 RID: 11684
		// (get) Token: 0x060095A2 RID: 38306 RVA: 0x0026AC18 File Offset: 0x00268E18
		// (set) Token: 0x060095A3 RID: 38307 RVA: 0x00048320 File Offset: 0x00046520
		public unsafe TextMeshProUGUI confirmText_Online
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModMenu.NativeFieldInfoPtr_confirmText_Online);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModMenu.NativeFieldInfoPtr_confirmText_Online), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DA5 RID: 11685
		// (get) Token: 0x060095A4 RID: 38308 RVA: 0x0026AC48 File Offset: 0x00268E48
		// (set) Token: 0x060095A5 RID: 38309 RVA: 0x0004833F File Offset: 0x0004653F
		public unsafe Transform CameraPosition
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModMenu.NativeFieldInfoPtr_CameraPosition);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModMenu.NativeFieldInfoPtr_CameraPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DA6 RID: 11686
		// (get) Token: 0x060095A6 RID: 38310 RVA: 0x0026AC78 File Offset: 0x00268E78
		// (set) Token: 0x060095A7 RID: 38311 RVA: 0x0004835E File Offset: 0x0004655E
		public unsafe Transform VehiclePosition
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModMenu.NativeFieldInfoPtr_VehiclePosition);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModMenu.NativeFieldInfoPtr_VehiclePosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DA7 RID: 11687
		// (get) Token: 0x060095A8 RID: 38312 RVA: 0x0026ACA8 File Offset: 0x00268EA8
		// (set) Token: 0x060095A9 RID: 38313 RVA: 0x0004837D File Offset: 0x0004657D
		public unsafe GameObject buttonPrefab
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModMenu.NativeFieldInfoPtr_buttonPrefab);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModMenu.NativeFieldInfoPtr_buttonPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DA8 RID: 11688
		// (get) Token: 0x060095AA RID: 38314 RVA: 0x0026ACD8 File Offset: 0x00268ED8
		// (set) Token: 0x060095AB RID: 38315 RVA: 0x0004839C File Offset: 0x0004659C
		public unsafe UnityEvent onPaintPurchased
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModMenu.NativeFieldInfoPtr_onPaintPurchased);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModMenu.NativeFieldInfoPtr_onPaintPurchased), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DA9 RID: 11689
		// (get) Token: 0x060095AC RID: 38316 RVA: 0x0026AD08 File Offset: 0x00268F08
		// (set) Token: 0x060095AD RID: 38317 RVA: 0x000483BB File Offset: 0x000465BB
		public unsafe LandVehicle currentVehicle
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModMenu.NativeFieldInfoPtr_currentVehicle);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModMenu.NativeFieldInfoPtr_currentVehicle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DAA RID: 11690
		// (get) Token: 0x060095AE RID: 38318 RVA: 0x0026AD38 File Offset: 0x00268F38
		// (set) Token: 0x060095AF RID: 38319 RVA: 0x000483DA File Offset: 0x000465DA
		public unsafe List<RectTransform> colorButtons
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModMenu.NativeFieldInfoPtr_colorButtons);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RectTransform>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModMenu.NativeFieldInfoPtr_colorButtons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DAB RID: 11691
		// (get) Token: 0x060095B0 RID: 38320 RVA: 0x0026AD68 File Offset: 0x00268F68
		// (set) Token: 0x060095B1 RID: 38321 RVA: 0x000483F9 File Offset: 0x000465F9
		public unsafe Dictionary<EVehicleColor, RectTransform> colorToButton
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModMenu.NativeFieldInfoPtr_colorToButton);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<EVehicleColor, RectTransform>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModMenu.NativeFieldInfoPtr_colorToButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DAC RID: 11692
		// (get) Token: 0x060095B2 RID: 38322 RVA: 0x0026AD98 File Offset: 0x00268F98
		// (set) Token: 0x060095B3 RID: 38323 RVA: 0x00048418 File Offset: 0x00046618
		public unsafe EVehicleColor selectedColor
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModMenu.NativeFieldInfoPtr_selectedColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModMenu.NativeFieldInfoPtr_selectedColor)) = value;
			}
		}

		// Token: 0x17002DAD RID: 11693
		// (get) Token: 0x060095B4 RID: 38324 RVA: 0x0026ADC0 File Offset: 0x00268FC0
		// (set) Token: 0x060095B5 RID: 38325 RVA: 0x00048433 File Offset: 0x00046633
		public unsafe Coroutine openCloseRoutine
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModMenu.NativeFieldInfoPtr_openCloseRoutine);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModMenu.NativeFieldInfoPtr_openCloseRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040064FA RID: 25850
		private static readonly System.IntPtr NativeFieldInfoPtr_repaintCost;

		// Token: 0x040064FB RID: 25851
		private static readonly System.IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x040064FC RID: 25852
		private static readonly System.IntPtr NativeFieldInfoPtr_canvas;

		// Token: 0x040064FD RID: 25853
		private static readonly System.IntPtr NativeFieldInfoPtr_buttonContainer;

		// Token: 0x040064FE RID: 25854
		private static readonly System.IntPtr NativeFieldInfoPtr_tempIndicator;

		// Token: 0x040064FF RID: 25855
		private static readonly System.IntPtr NativeFieldInfoPtr_permIndicator;

		// Token: 0x04006500 RID: 25856
		private static readonly System.IntPtr NativeFieldInfoPtr_confirmButton_Online;

		// Token: 0x04006501 RID: 25857
		private static readonly System.IntPtr NativeFieldInfoPtr_confirmText_Online;

		// Token: 0x04006502 RID: 25858
		private static readonly System.IntPtr NativeFieldInfoPtr_CameraPosition;

		// Token: 0x04006503 RID: 25859
		private static readonly System.IntPtr NativeFieldInfoPtr_VehiclePosition;

		// Token: 0x04006504 RID: 25860
		private static readonly System.IntPtr NativeFieldInfoPtr_buttonPrefab;

		// Token: 0x04006505 RID: 25861
		private static readonly System.IntPtr NativeFieldInfoPtr_onPaintPurchased;

		// Token: 0x04006506 RID: 25862
		private static readonly System.IntPtr NativeFieldInfoPtr_currentVehicle;

		// Token: 0x04006507 RID: 25863
		private static readonly System.IntPtr NativeFieldInfoPtr_colorButtons;

		// Token: 0x04006508 RID: 25864
		private static readonly System.IntPtr NativeFieldInfoPtr_colorToButton;

		// Token: 0x04006509 RID: 25865
		private static readonly System.IntPtr NativeFieldInfoPtr_selectedColor;

		// Token: 0x0400650A RID: 25866
		private static readonly System.IntPtr NativeFieldInfoPtr_openCloseRoutine;

		// Token: 0x0400650B RID: 25867
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x0400650C RID: 25868
		private static readonly System.IntPtr NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0;

		// Token: 0x0400650D RID: 25869
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x0400650E RID: 25870
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x0400650F RID: 25871
		private static readonly System.IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x04006510 RID: 25872
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04006511 RID: 25873
		private static readonly System.IntPtr NativeMethodInfoPtr_Open_Public_Void_LandVehicle_0;

		// Token: 0x04006512 RID: 25874
		private static readonly System.IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04006513 RID: 25875
		private static readonly System.IntPtr NativeMethodInfoPtr_ColorClicked_Public_Void_EVehicleColor_0;

		// Token: 0x04006514 RID: 25876
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateConfirmButton_Private_Void_0;

		// Token: 0x04006515 RID: 25877
		private static readonly System.IntPtr NativeMethodInfoPtr_RefreshSelectionIndicator_Private_Void_0;

		// Token: 0x04006516 RID: 25878
		private static readonly System.IntPtr NativeMethodInfoPtr_ConfirmButtonClicked_Public_Void_0;

		// Token: 0x04006517 RID: 25879
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04006518 RID: 25880
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x04006519 RID: 25881
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1;

		// Token: 0x02000BA1 RID: 2977
		[ObfuscatedName("ScheduleOne.UI.VehicleModMenu+<<Close>g__Close|25_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0 : Il2CppSystem.Object
		{
			// Token: 0x0600DEE3 RID: 57059 RVA: 0x00350170 File Offset: 0x0034E370
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0()
			{
				Il2CppClassPointerStore<VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VehicleModMenu>.NativeClassPtr, "<<Close>g__Close|25_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0>.NativeClassPtr);
				VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0>.NativeClassPtr, "<>1__state");
				VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0>.NativeClassPtr, "<>2__current");
				VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0>.NativeClassPtr, "<>4__this");
				VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0>.NativeClassPtr, 100681943);
				VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0>.NativeClassPtr, 100681944);
				VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0>.NativeClassPtr, 100681945);
				VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0>.NativeClassPtr, 100681946);
				VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0>.NativeClassPtr, 100681947);
				VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0>.NativeClassPtr, 100681948);
			}

			// Token: 0x0600DEE4 RID: 57060 RVA: 0x00350250 File Offset: 0x0034E450
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DEE5 RID: 57061 RVA: 0x00350298 File Offset: 0x0034E498
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DEE6 RID: 57062 RVA: 0x003502CC File Offset: 0x0034E4CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269121, XrefRangeEnd = 269136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x170044D9 RID: 17625
			// (get) Token: 0x0600DEE7 RID: 57063 RVA: 0x00350308 File Offset: 0x0034E508
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600DEE8 RID: 57064 RVA: 0x00350348 File Offset: 0x0034E548
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269136, XrefRangeEnd = 269141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x170044DA RID: 17626
			// (get) Token: 0x0600DEE9 RID: 57065 RVA: 0x0035037C File Offset: 0x0034E57C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600DEEA RID: 57066 RVA: 0x0006C3B0 File Offset: 0x0006A5B0
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044D6 RID: 17622
			// (get) Token: 0x0600DEEB RID: 57067 RVA: 0x003503BC File Offset: 0x0034E5BC
			// (set) Token: 0x0600DEEC RID: 57068 RVA: 0x0006C3B9 File Offset: 0x0006A5B9
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170044D7 RID: 17623
			// (get) Token: 0x0600DEED RID: 57069 RVA: 0x003503E4 File Offset: 0x0034E5E4
			// (set) Token: 0x0600DEEE RID: 57070 RVA: 0x0006C3D4 File Offset: 0x0006A5D4
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044D8 RID: 17624
			// (get) Token: 0x0600DEEF RID: 57071 RVA: 0x00350414 File Offset: 0x0034E614
			// (set) Token: 0x0600DEF0 RID: 57072 RVA: 0x0006C3F3 File Offset: 0x0006A5F3
			public unsafe VehicleModMenu __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleModMenu>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040095C4 RID: 38340
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040095C5 RID: 38341
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040095C6 RID: 38342
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040095C7 RID: 38343
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040095C8 RID: 38344
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040095C9 RID: 38345
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040095CA RID: 38346
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040095CB RID: 38347
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040095CC RID: 38348
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000BA2 RID: 2978
		[ObfuscatedName("ScheduleOne.UI.VehicleModMenu+<<Open>g__Close|24_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1 : Il2CppSystem.Object
		{
			// Token: 0x0600DEF1 RID: 57073 RVA: 0x00350444 File Offset: 0x0034E644
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1()
			{
				Il2CppClassPointerStore<VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VehicleModMenu>.NativeClassPtr, "<<Open>g__Close|24_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1>.NativeClassPtr);
				VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1>.NativeClassPtr, "<>1__state");
				VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1>.NativeClassPtr, "<>2__current");
				VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1>.NativeClassPtr, "<>4__this");
				VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1>.NativeClassPtr, 100681949);
				VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1>.NativeClassPtr, 100681950);
				VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1>.NativeClassPtr, 100681951);
				VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1>.NativeClassPtr, 100681952);
				VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1>.NativeClassPtr, 100681953);
				VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1>.NativeClassPtr, 100681954);
			}

			// Token: 0x0600DEF2 RID: 57074 RVA: 0x00350524 File Offset: 0x0034E724
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DEF3 RID: 57075 RVA: 0x0035056C File Offset: 0x0034E76C
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DEF4 RID: 57076 RVA: 0x003505A0 File Offset: 0x0034E7A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269141, XrefRangeEnd = 269182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x170044DE RID: 17630
			// (get) Token: 0x0600DEF5 RID: 57077 RVA: 0x003505DC File Offset: 0x0034E7DC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600DEF6 RID: 57078 RVA: 0x0035061C File Offset: 0x0034E81C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269182, XrefRangeEnd = 269187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x170044DF RID: 17631
			// (get) Token: 0x0600DEF7 RID: 57079 RVA: 0x00350650 File Offset: 0x0034E850
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600DEF8 RID: 57080 RVA: 0x0006C412 File Offset: 0x0006A612
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044DB RID: 17627
			// (get) Token: 0x0600DEF9 RID: 57081 RVA: 0x00350690 File Offset: 0x0034E890
			// (set) Token: 0x0600DEFA RID: 57082 RVA: 0x0006C41B File Offset: 0x0006A61B
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170044DC RID: 17628
			// (get) Token: 0x0600DEFB RID: 57083 RVA: 0x003506B8 File Offset: 0x0034E8B8
			// (set) Token: 0x0600DEFC RID: 57084 RVA: 0x0006C436 File Offset: 0x0006A636
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044DD RID: 17629
			// (get) Token: 0x0600DEFD RID: 57085 RVA: 0x003506E8 File Offset: 0x0034E8E8
			// (set) Token: 0x0600DEFE RID: 57086 RVA: 0x0006C455 File Offset: 0x0006A655
			public unsafe VehicleModMenu __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleModMenu>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040095CD RID: 38349
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040095CE RID: 38350
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040095CF RID: 38351
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040095D0 RID: 38352
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040095D1 RID: 38353
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040095D2 RID: 38354
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040095D3 RID: 38355
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040095D4 RID: 38356
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040095D5 RID: 38357
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000BA3 RID: 2979
		[ObfuscatedName("ScheduleOne.UI.VehicleModMenu+<>c__DisplayClass21_0")]
		public sealed class __c__DisplayClass21_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DEFF RID: 57087 RVA: 0x00350718 File Offset: 0x0034E918
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass21_0()
			{
				Il2CppClassPointerStore<VehicleModMenu.__c__DisplayClass21_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VehicleModMenu>.NativeClassPtr, "<>c__DisplayClass21_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleModMenu.__c__DisplayClass21_0>.NativeClassPtr);
				VehicleModMenu.__c__DisplayClass21_0.NativeFieldInfoPtr_c = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleModMenu.__c__DisplayClass21_0>.NativeClassPtr, "c");
				VehicleModMenu.__c__DisplayClass21_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleModMenu.__c__DisplayClass21_0>.NativeClassPtr, "<>4__this");
				VehicleModMenu.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleModMenu.__c__DisplayClass21_0>.NativeClassPtr, 100681955);
				VehicleModMenu.__c__DisplayClass21_0.NativeMethodInfoPtr__Start_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleModMenu.__c__DisplayClass21_0>.NativeClassPtr, 100681956);
			}

			// Token: 0x0600DF00 RID: 57088 RVA: 0x00350794 File Offset: 0x0034E994
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass21_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleModMenu.__c__DisplayClass21_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleModMenu.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DF01 RID: 57089 RVA: 0x003507D0 File Offset: 0x0034E9D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269187, XrefRangeEnd = 269190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Start_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleModMenu.__c__DisplayClass21_0.NativeMethodInfoPtr__Start_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DF02 RID: 57090 RVA: 0x0006C474 File Offset: 0x0006A674
			public __c__DisplayClass21_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044E0 RID: 17632
			// (get) Token: 0x0600DF03 RID: 57091 RVA: 0x00350804 File Offset: 0x0034EA04
			// (set) Token: 0x0600DF04 RID: 57092 RVA: 0x0006C47D File Offset: 0x0006A67D
			public unsafe EVehicleColor c
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModMenu.__c__DisplayClass21_0.NativeFieldInfoPtr_c);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModMenu.__c__DisplayClass21_0.NativeFieldInfoPtr_c)) = value;
				}
			}

			// Token: 0x170044E1 RID: 17633
			// (get) Token: 0x0600DF05 RID: 57093 RVA: 0x0035082C File Offset: 0x0034EA2C
			// (set) Token: 0x0600DF06 RID: 57094 RVA: 0x0006C498 File Offset: 0x0006A698
			public unsafe VehicleModMenu __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModMenu.__c__DisplayClass21_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleModMenu>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModMenu.__c__DisplayClass21_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040095D6 RID: 38358
			private static readonly System.IntPtr NativeFieldInfoPtr_c;

			// Token: 0x040095D7 RID: 38359
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040095D8 RID: 38360
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040095D9 RID: 38361
			private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__0_Internal_Void_0;
		}
	}
}
