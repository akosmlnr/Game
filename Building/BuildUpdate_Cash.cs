using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Interaction;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Building
{
	// Token: 0x020004DE RID: 1246
	public class BuildUpdate_Cash : BuildUpdate_StoredItem
	{
		// Token: 0x06006C0E RID: 27662 RVA: 0x001E513C File Offset: 0x001E333C
		// Note: this type is marked as 'beforefieldinit'.
		static BuildUpdate_Cash()
		{
			Il2CppClassPointerStore<BuildUpdate_Cash>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Building", "BuildUpdate_Cash");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildUpdate_Cash>.NativeClassPtr);
			BuildUpdate_Cash.NativeFieldInfoPtr_amountIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_Cash>.NativeClassPtr, "amountIndex");
			BuildUpdate_Cash.NativeFieldInfoPtr_bills = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_Cash>.NativeClassPtr, "bills");
			BuildUpdate_Cash.NativeFieldInfoPtr_amountLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_Cash>.NativeClassPtr, "amountLabel");
			BuildUpdate_Cash.NativeMethodInfoPtr_get_placeAmount_Private_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Cash>.NativeClassPtr, 100677113);
			BuildUpdate_Cash.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Cash>.NativeClassPtr, 100677114);
			BuildUpdate_Cash.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Cash>.NativeClassPtr, 100677115);
			BuildUpdate_Cash.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Cash>.NativeClassPtr, 100677116);
			BuildUpdate_Cash.NativeMethodInfoPtr_UpdateLabel_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Cash>.NativeClassPtr, 100677117);
			BuildUpdate_Cash.NativeMethodInfoPtr_RefreshGhostModelAppearance_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Cash>.NativeClassPtr, 100677118);
			BuildUpdate_Cash.NativeMethodInfoPtr_Place_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Cash>.NativeClassPtr, 100677119);
			BuildUpdate_Cash.NativeMethodInfoPtr_PostPlace_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Cash>.NativeClassPtr, 100677120);
			BuildUpdate_Cash.NativeMethodInfoPtr_Stop_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Cash>.NativeClassPtr, 100677121);
			BuildUpdate_Cash.NativeMethodInfoPtr_GetRelevantCashBalane_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Cash>.NativeClassPtr, 100677122);
			BuildUpdate_Cash.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Cash>.NativeClassPtr, 100677123);
		}

		// Token: 0x1700203E RID: 8254
		// (get) Token: 0x06006C0F RID: 27663 RVA: 0x001E5284 File Offset: 0x001E3484
		public unsafe float placeAmount
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 217990, RefRangeEnd = 217993, XrefRangeStart = 217986, XrefRangeEnd = 217990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_Cash.NativeMethodInfoPtr_get_placeAmount_Private_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x06006C10 RID: 27664 RVA: 0x001E52C0 File Offset: 0x001E34C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217993, XrefRangeEnd = 218015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_Cash.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006C11 RID: 27665 RVA: 0x001E52F4 File Offset: 0x001E34F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218015, XrefRangeEnd = 218034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildUpdate_Cash.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006C12 RID: 27666 RVA: 0x001E5330 File Offset: 0x001E3530
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218034, XrefRangeEnd = 218069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildUpdate_Cash.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006C13 RID: 27667 RVA: 0x001E536C File Offset: 0x001E356C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 218087, RefRangeEnd = 218088, XrefRangeStart = 218069, XrefRangeEnd = 218087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateLabel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_Cash.NativeMethodInfoPtr_UpdateLabel_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006C14 RID: 27668 RVA: 0x001E53A0 File Offset: 0x001E35A0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 218102, RefRangeEnd = 218106, XrefRangeStart = 218088, XrefRangeEnd = 218102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshGhostModelAppearance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_Cash.NativeMethodInfoPtr_RefreshGhostModelAppearance_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006C15 RID: 27669 RVA: 0x001E53D4 File Offset: 0x001E35D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218106, XrefRangeEnd = 218143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Place()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildUpdate_Cash.NativeMethodInfoPtr_Place_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006C16 RID: 27670 RVA: 0x001E5410 File Offset: 0x001E3610
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218143, XrefRangeEnd = 218152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PostPlace()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildUpdate_Cash.NativeMethodInfoPtr_PostPlace_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006C17 RID: 27671 RVA: 0x001E544C File Offset: 0x001E364C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218152, XrefRangeEnd = 218154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Stop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildUpdate_Cash.NativeMethodInfoPtr_Stop_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006C18 RID: 27672 RVA: 0x001E5488 File Offset: 0x001E3688
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 218160, RefRangeEnd = 218162, XrefRangeStart = 218154, XrefRangeEnd = 218160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetRelevantCashBalane()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_Cash.NativeMethodInfoPtr_GetRelevantCashBalane_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06006C19 RID: 27673 RVA: 0x001E54C4 File Offset: 0x001E36C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218162, XrefRangeEnd = 218172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuildUpdate_Cash() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildUpdate_Cash>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_Cash.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006C1A RID: 27674 RVA: 0x00032CC0 File Offset: 0x00030EC0
		public BuildUpdate_Cash(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700203B RID: 8251
		// (get) Token: 0x06006C1B RID: 27675 RVA: 0x001E5500 File Offset: 0x001E3700
		// (set) Token: 0x06006C1C RID: 27676 RVA: 0x00032CC9 File Offset: 0x00030EC9
		public unsafe int amountIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Cash.NativeFieldInfoPtr_amountIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Cash.NativeFieldInfoPtr_amountIndex)) = value;
			}
		}

		// Token: 0x1700203C RID: 8252
		// (get) Token: 0x06006C1D RID: 27677 RVA: 0x001E5528 File Offset: 0x001E3728
		// (set) Token: 0x06006C1E RID: 27678 RVA: 0x00032CE4 File Offset: 0x00030EE4
		public unsafe List<Transform> bills
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Cash.NativeFieldInfoPtr_bills);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Cash.NativeFieldInfoPtr_bills), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700203D RID: 8253
		// (get) Token: 0x06006C1F RID: 27679 RVA: 0x001E5558 File Offset: 0x001E3758
		// (set) Token: 0x06006C20 RID: 27680 RVA: 0x00032D03 File Offset: 0x00030F03
		public unsafe WorldSpaceLabel amountLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Cash.NativeFieldInfoPtr_amountLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorldSpaceLabel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Cash.NativeFieldInfoPtr_amountLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040049FF RID: 18943
		private static readonly IntPtr NativeFieldInfoPtr_amountIndex;

		// Token: 0x04004A00 RID: 18944
		private static readonly IntPtr NativeFieldInfoPtr_bills;

		// Token: 0x04004A01 RID: 18945
		private static readonly IntPtr NativeFieldInfoPtr_amountLabel;

		// Token: 0x04004A02 RID: 18946
		private static readonly IntPtr NativeMethodInfoPtr_get_placeAmount_Private_get_Single_0;

		// Token: 0x04004A03 RID: 18947
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04004A04 RID: 18948
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x04004A05 RID: 18949
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_Void_0;

		// Token: 0x04004A06 RID: 18950
		private static readonly IntPtr NativeMethodInfoPtr_UpdateLabel_Private_Void_0;

		// Token: 0x04004A07 RID: 18951
		private static readonly IntPtr NativeMethodInfoPtr_RefreshGhostModelAppearance_Private_Void_0;

		// Token: 0x04004A08 RID: 18952
		private static readonly IntPtr NativeMethodInfoPtr_Place_Protected_Virtual_Void_0;

		// Token: 0x04004A09 RID: 18953
		private static readonly IntPtr NativeMethodInfoPtr_PostPlace_Protected_Virtual_Void_0;

		// Token: 0x04004A0A RID: 18954
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Virtual_Void_0;

		// Token: 0x04004A0B RID: 18955
		private static readonly IntPtr NativeMethodInfoPtr_GetRelevantCashBalane_Public_Single_0;

		// Token: 0x04004A0C RID: 18956
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
