using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Vehicles;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000696 RID: 1686
	public class VehicleCanvas : Singleton<VehicleCanvas>
	{
		// Token: 0x06009571 RID: 38257 RVA: 0x0026A0F0 File Offset: 0x002682F0
		// Note: this type is marked as 'beforefieldinit'.
		static VehicleCanvas()
		{
			Il2CppClassPointerStore<VehicleCanvas>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "VehicleCanvas");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleCanvas>.NativeClassPtr);
			VehicleCanvas.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCanvas>.NativeClassPtr, "Canvas");
			VehicleCanvas.NativeFieldInfoPtr_SpeedText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCanvas>.NativeClassPtr, "SpeedText");
			VehicleCanvas.NativeFieldInfoPtr_DriverPromptsContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCanvas>.NativeClassPtr, "DriverPromptsContainer");
			VehicleCanvas.NativeFieldInfoPtr_currentVehicle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCanvas>.NativeClassPtr, "currentVehicle");
			VehicleCanvas.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleCanvas>.NativeClassPtr, 100681919);
			VehicleCanvas.NativeMethodInfoPtr_Subscribe_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleCanvas>.NativeClassPtr, 100681920);
			VehicleCanvas.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleCanvas>.NativeClassPtr, 100681921);
			VehicleCanvas.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleCanvas>.NativeClassPtr, 100681922);
			VehicleCanvas.NativeMethodInfoPtr_VehicleEntered_Private_Void_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleCanvas>.NativeClassPtr, 100681923);
			VehicleCanvas.NativeMethodInfoPtr_VehicleExited_Private_Void_LandVehicle_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleCanvas>.NativeClassPtr, 100681924);
			VehicleCanvas.NativeMethodInfoPtr_UpdateSpeedText_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleCanvas>.NativeClassPtr, 100681925);
			VehicleCanvas.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleCanvas>.NativeClassPtr, 100681926);
		}

		// Token: 0x06009572 RID: 38258 RVA: 0x0026A210 File Offset: 0x00268410
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269013, XrefRangeEnd = 269036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleCanvas.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009573 RID: 38259 RVA: 0x0026A24C File Offset: 0x0026844C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269036, XrefRangeEnd = 269068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Subscribe()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleCanvas.NativeMethodInfoPtr_Subscribe_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009574 RID: 38260 RVA: 0x0026A280 File Offset: 0x00268480
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269068, XrefRangeEnd = 269087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleCanvas.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009575 RID: 38261 RVA: 0x0026A2B4 File Offset: 0x002684B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269087, XrefRangeEnd = 269092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleCanvas.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009576 RID: 38262 RVA: 0x0026A2E8 File Offset: 0x002684E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269092, XrefRangeEnd = 269097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void VehicleEntered(LandVehicle veh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(veh);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleCanvas.NativeMethodInfoPtr_VehicleEntered_Private_Void_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009577 RID: 38263 RVA: 0x0026A32C File Offset: 0x0026852C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269097, XrefRangeEnd = 269100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void VehicleExited(LandVehicle veh, Transform exitPoint)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(veh);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(exitPoint);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleCanvas.NativeMethodInfoPtr_VehicleExited_Private_Void_LandVehicle_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009578 RID: 38264 RVA: 0x0026A380 File Offset: 0x00268580
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 269116, RefRangeEnd = 269118, XrefRangeStart = 269100, XrefRangeEnd = 269116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSpeedText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleCanvas.NativeMethodInfoPtr_UpdateSpeedText_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009579 RID: 38265 RVA: 0x0026A3B4 File Offset: 0x002685B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269118, XrefRangeEnd = 269121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleCanvas() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleCanvas>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleCanvas.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600957A RID: 38266 RVA: 0x000481CE File Offset: 0x000463CE
		public VehicleCanvas(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002D99 RID: 11673
		// (get) Token: 0x0600957B RID: 38267 RVA: 0x0026A3F0 File Offset: 0x002685F0
		// (set) Token: 0x0600957C RID: 38268 RVA: 0x000481D7 File Offset: 0x000463D7
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCanvas.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCanvas.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D9A RID: 11674
		// (get) Token: 0x0600957D RID: 38269 RVA: 0x0026A420 File Offset: 0x00268620
		// (set) Token: 0x0600957E RID: 38270 RVA: 0x000481F6 File Offset: 0x000463F6
		public unsafe TextMeshProUGUI SpeedText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCanvas.NativeFieldInfoPtr_SpeedText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCanvas.NativeFieldInfoPtr_SpeedText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D9B RID: 11675
		// (get) Token: 0x0600957F RID: 38271 RVA: 0x0026A450 File Offset: 0x00268650
		// (set) Token: 0x06009580 RID: 38272 RVA: 0x00048215 File Offset: 0x00046415
		public unsafe GameObject DriverPromptsContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCanvas.NativeFieldInfoPtr_DriverPromptsContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCanvas.NativeFieldInfoPtr_DriverPromptsContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D9C RID: 11676
		// (get) Token: 0x06009581 RID: 38273 RVA: 0x0026A480 File Offset: 0x00268680
		// (set) Token: 0x06009582 RID: 38274 RVA: 0x00048234 File Offset: 0x00046434
		public unsafe LandVehicle currentVehicle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCanvas.NativeFieldInfoPtr_currentVehicle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCanvas.NativeFieldInfoPtr_currentVehicle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040064EE RID: 25838
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x040064EF RID: 25839
		private static readonly IntPtr NativeFieldInfoPtr_SpeedText;

		// Token: 0x040064F0 RID: 25840
		private static readonly IntPtr NativeFieldInfoPtr_DriverPromptsContainer;

		// Token: 0x040064F1 RID: 25841
		private static readonly IntPtr NativeFieldInfoPtr_currentVehicle;

		// Token: 0x040064F2 RID: 25842
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040064F3 RID: 25843
		private static readonly IntPtr NativeMethodInfoPtr_Subscribe_Private_Void_0;

		// Token: 0x040064F4 RID: 25844
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040064F5 RID: 25845
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x040064F6 RID: 25846
		private static readonly IntPtr NativeMethodInfoPtr_VehicleEntered_Private_Void_LandVehicle_0;

		// Token: 0x040064F7 RID: 25847
		private static readonly IntPtr NativeMethodInfoPtr_VehicleExited_Private_Void_LandVehicle_Transform_0;

		// Token: 0x040064F8 RID: 25848
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSpeedText_Private_Void_0;

		// Token: 0x040064F9 RID: 25849
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
