using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ConstructableScripts;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.Property.Utilities.Power;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Construction.ConstructionMethods
{
	// Token: 0x020004B1 RID: 1201
	public class ConstructUpdate_PowerTower : ConstructUpdate_OutdoorGrid
	{
		// Token: 0x060066EC RID: 26348 RVA: 0x001D2B10 File Offset: 0x001D0D10
		// Note: this type is marked as 'beforefieldinit'.
		static ConstructUpdate_PowerTower()
		{
			Il2CppClassPointerStore<ConstructUpdate_PowerTower>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Construction.ConstructionMethods", "ConstructUpdate_PowerTower");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstructUpdate_PowerTower>.NativeClassPtr);
			ConstructUpdate_PowerTower.NativeFieldInfoPtr_specialMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructUpdate_PowerTower>.NativeClassPtr, "specialMat");
			ConstructUpdate_PowerTower.NativeFieldInfoPtr_powerLine_GhostMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructUpdate_PowerTower>.NativeClassPtr, "powerLine_GhostMat");
			ConstructUpdate_PowerTower.NativeFieldInfoPtr_cosmeticPowerNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructUpdate_PowerTower>.NativeClassPtr, "cosmeticPowerNode");
			ConstructUpdate_PowerTower.NativeFieldInfoPtr_LengthFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructUpdate_PowerTower>.NativeClassPtr, "LengthFactor");
			ConstructUpdate_PowerTower.NativeFieldInfoPtr_tempPowerLineContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructUpdate_PowerTower>.NativeClassPtr, "tempPowerLineContainer");
			ConstructUpdate_PowerTower.NativeFieldInfoPtr_tempSegments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructUpdate_PowerTower>.NativeClassPtr, "tempSegments");
			ConstructUpdate_PowerTower.NativeFieldInfoPtr_hoveredPowerNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructUpdate_PowerTower>.NativeClassPtr, "hoveredPowerNode");
			ConstructUpdate_PowerTower.NativeFieldInfoPtr_startNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructUpdate_PowerTower>.NativeClassPtr, "startNode");
			ConstructUpdate_PowerTower.NativeFieldInfoPtr_powerLineInitialDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructUpdate_PowerTower>.NativeClassPtr, "powerLineInitialDistance");
			ConstructUpdate_PowerTower.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_PowerTower>.NativeClassPtr, 100676423);
			ConstructUpdate_PowerTower.NativeMethodInfoPtr_ConstructionStop_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_PowerTower>.NativeClassPtr, 100676424);
			ConstructUpdate_PowerTower.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_PowerTower>.NativeClassPtr, 100676425);
			ConstructUpdate_PowerTower.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_PowerTower>.NativeClassPtr, 100676426);
			ConstructUpdate_PowerTower.NativeMethodInfoPtr_Exit_Public_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_PowerTower>.NativeClassPtr, 100676427);
			ConstructUpdate_PowerTower.NativeMethodInfoPtr_GetHoveredPowerTower_Private_PowerTower_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_PowerTower>.NativeClassPtr, 100676428);
			ConstructUpdate_PowerTower.NativeMethodInfoPtr_GetHoveredPowerNode_Protected_PowerNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_PowerTower>.NativeClassPtr, 100676429);
			ConstructUpdate_PowerTower.NativeMethodInfoPtr_PlaceNewConstructable_Protected_Virtual_Constructable_GridBased_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_PowerTower>.NativeClassPtr, 100676430);
			ConstructUpdate_PowerTower.NativeMethodInfoPtr_CompletePowerLine_Private_Void_PowerNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_PowerTower>.NativeClassPtr, 100676431);
			ConstructUpdate_PowerTower.NativeMethodInfoPtr_StopCreatingPowerLine_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_PowerTower>.NativeClassPtr, 100676432);
			ConstructUpdate_PowerTower.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructUpdate_PowerTower>.NativeClassPtr, 100676433);
		}

		// Token: 0x060066ED RID: 26349 RVA: 0x001D2CD0 File Offset: 0x001D0ED0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209647, XrefRangeEnd = 209700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstructUpdate_PowerTower.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060066EE RID: 26350 RVA: 0x001D2D0C File Offset: 0x001D0F0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209700, XrefRangeEnd = 209711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ConstructionStop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstructUpdate_PowerTower.NativeMethodInfoPtr_ConstructionStop_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060066EF RID: 26351 RVA: 0x001D2D48 File Offset: 0x001D0F48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209711, XrefRangeEnd = 209745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstructUpdate_PowerTower.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060066F0 RID: 26352 RVA: 0x001D2D84 File Offset: 0x001D0F84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209745, XrefRangeEnd = 209823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstructUpdate_PowerTower.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060066F1 RID: 26353 RVA: 0x001D2DC0 File Offset: 0x001D0FC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209823, XrefRangeEnd = 209829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction exit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(exit);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructUpdate_PowerTower.NativeMethodInfoPtr_Exit_Public_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060066F2 RID: 26354 RVA: 0x001D2E04 File Offset: 0x001D1004
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209829, XrefRangeEnd = 209861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PowerTower GetHoveredPowerTower()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructUpdate_PowerTower.NativeMethodInfoPtr_GetHoveredPowerTower_Private_PowerTower_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<PowerTower>(intPtr2) : null;
		}

		// Token: 0x060066F3 RID: 26355 RVA: 0x001D2E44 File Offset: 0x001D1044
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 209881, RefRangeEnd = 209883, XrefRangeStart = 209861, XrefRangeEnd = 209881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PowerNode GetHoveredPowerNode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructUpdate_PowerTower.NativeMethodInfoPtr_GetHoveredPowerNode_Protected_PowerNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<PowerNode>(intPtr2) : null;
		}

		// Token: 0x060066F4 RID: 26356 RVA: 0x001D2E84 File Offset: 0x001D1084
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209883, XrefRangeEnd = 209912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Constructable_GridBased PlaceNewConstructable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstructUpdate_PowerTower.NativeMethodInfoPtr_PlaceNewConstructable_Protected_Virtual_Constructable_GridBased_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Constructable_GridBased>(intPtr2) : null;
		}

		// Token: 0x060066F5 RID: 26357 RVA: 0x001D2ED0 File Offset: 0x001D10D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 209935, RefRangeEnd = 209936, XrefRangeStart = 209912, XrefRangeEnd = 209935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompletePowerLine(PowerNode target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructUpdate_PowerTower.NativeMethodInfoPtr_CompletePowerLine_Private_Void_PowerNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060066F6 RID: 26358 RVA: 0x001D2F14 File Offset: 0x001D1114
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 209949, RefRangeEnd = 209952, XrefRangeStart = 209936, XrefRangeEnd = 209949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopCreatingPowerLine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructUpdate_PowerTower.NativeMethodInfoPtr_StopCreatingPowerLine_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060066F7 RID: 26359 RVA: 0x001D2F48 File Offset: 0x001D1148
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209952, XrefRangeEnd = 209962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConstructUpdate_PowerTower() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstructUpdate_PowerTower>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructUpdate_PowerTower.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060066F8 RID: 26360 RVA: 0x000306FB File Offset: 0x0002E8FB
		public ConstructUpdate_PowerTower(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001ECA RID: 7882
		// (get) Token: 0x060066F9 RID: 26361 RVA: 0x001D2F84 File Offset: 0x001D1184
		// (set) Token: 0x060066FA RID: 26362 RVA: 0x00030704 File Offset: 0x0002E904
		public unsafe Material specialMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_PowerTower.NativeFieldInfoPtr_specialMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_PowerTower.NativeFieldInfoPtr_specialMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001ECB RID: 7883
		// (get) Token: 0x060066FB RID: 26363 RVA: 0x001D2FB4 File Offset: 0x001D11B4
		// (set) Token: 0x060066FC RID: 26364 RVA: 0x00030723 File Offset: 0x0002E923
		public unsafe Material powerLine_GhostMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_PowerTower.NativeFieldInfoPtr_powerLine_GhostMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_PowerTower.NativeFieldInfoPtr_powerLine_GhostMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001ECC RID: 7884
		// (get) Token: 0x060066FD RID: 26365 RVA: 0x001D2FE4 File Offset: 0x001D11E4
		// (set) Token: 0x060066FE RID: 26366 RVA: 0x00030742 File Offset: 0x0002E942
		public unsafe GameObject cosmeticPowerNode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_PowerTower.NativeFieldInfoPtr_cosmeticPowerNode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_PowerTower.NativeFieldInfoPtr_cosmeticPowerNode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001ECD RID: 7885
		// (get) Token: 0x060066FF RID: 26367 RVA: 0x001D3014 File Offset: 0x001D1214
		// (set) Token: 0x06006700 RID: 26368 RVA: 0x00030761 File Offset: 0x0002E961
		public unsafe float LengthFactor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_PowerTower.NativeFieldInfoPtr_LengthFactor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_PowerTower.NativeFieldInfoPtr_LengthFactor)) = value;
			}
		}

		// Token: 0x17001ECE RID: 7886
		// (get) Token: 0x06006701 RID: 26369 RVA: 0x001D303C File Offset: 0x001D123C
		// (set) Token: 0x06006702 RID: 26370 RVA: 0x0003077C File Offset: 0x0002E97C
		public unsafe Transform tempPowerLineContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_PowerTower.NativeFieldInfoPtr_tempPowerLineContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_PowerTower.NativeFieldInfoPtr_tempPowerLineContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001ECF RID: 7887
		// (get) Token: 0x06006703 RID: 26371 RVA: 0x001D306C File Offset: 0x001D126C
		// (set) Token: 0x06006704 RID: 26372 RVA: 0x0003079B File Offset: 0x0002E99B
		public unsafe List<Transform> tempSegments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_PowerTower.NativeFieldInfoPtr_tempSegments);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_PowerTower.NativeFieldInfoPtr_tempSegments), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001ED0 RID: 7888
		// (get) Token: 0x06006705 RID: 26373 RVA: 0x001D309C File Offset: 0x001D129C
		// (set) Token: 0x06006706 RID: 26374 RVA: 0x000307BA File Offset: 0x0002E9BA
		public unsafe PowerNode hoveredPowerNode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_PowerTower.NativeFieldInfoPtr_hoveredPowerNode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PowerNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_PowerTower.NativeFieldInfoPtr_hoveredPowerNode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001ED1 RID: 7889
		// (get) Token: 0x06006707 RID: 26375 RVA: 0x001D30CC File Offset: 0x001D12CC
		// (set) Token: 0x06006708 RID: 26376 RVA: 0x000307D9 File Offset: 0x0002E9D9
		public unsafe PowerNode startNode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_PowerTower.NativeFieldInfoPtr_startNode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PowerNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_PowerTower.NativeFieldInfoPtr_startNode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001ED2 RID: 7890
		// (get) Token: 0x06006709 RID: 26377 RVA: 0x001D30FC File Offset: 0x001D12FC
		// (set) Token: 0x0600670A RID: 26378 RVA: 0x000307F8 File Offset: 0x0002E9F8
		public unsafe float powerLineInitialDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_PowerTower.NativeFieldInfoPtr_powerLineInitialDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructUpdate_PowerTower.NativeFieldInfoPtr_powerLineInitialDistance)) = value;
			}
		}

		// Token: 0x04004639 RID: 17977
		private static readonly IntPtr NativeFieldInfoPtr_specialMat;

		// Token: 0x0400463A RID: 17978
		private static readonly IntPtr NativeFieldInfoPtr_powerLine_GhostMat;

		// Token: 0x0400463B RID: 17979
		private static readonly IntPtr NativeFieldInfoPtr_cosmeticPowerNode;

		// Token: 0x0400463C RID: 17980
		private static readonly IntPtr NativeFieldInfoPtr_LengthFactor;

		// Token: 0x0400463D RID: 17981
		private static readonly IntPtr NativeFieldInfoPtr_tempPowerLineContainer;

		// Token: 0x0400463E RID: 17982
		private static readonly IntPtr NativeFieldInfoPtr_tempSegments;

		// Token: 0x0400463F RID: 17983
		private static readonly IntPtr NativeFieldInfoPtr_hoveredPowerNode;

		// Token: 0x04004640 RID: 17984
		private static readonly IntPtr NativeFieldInfoPtr_startNode;

		// Token: 0x04004641 RID: 17985
		private static readonly IntPtr NativeFieldInfoPtr_powerLineInitialDistance;

		// Token: 0x04004642 RID: 17986
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04004643 RID: 17987
		private static readonly IntPtr NativeMethodInfoPtr_ConstructionStop_Public_Virtual_Void_0;

		// Token: 0x04004644 RID: 17988
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x04004645 RID: 17989
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_Void_0;

		// Token: 0x04004646 RID: 17990
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Public_Void_ExitAction_0;

		// Token: 0x04004647 RID: 17991
		private static readonly IntPtr NativeMethodInfoPtr_GetHoveredPowerTower_Private_PowerTower_0;

		// Token: 0x04004648 RID: 17992
		private static readonly IntPtr NativeMethodInfoPtr_GetHoveredPowerNode_Protected_PowerNode_0;

		// Token: 0x04004649 RID: 17993
		private static readonly IntPtr NativeMethodInfoPtr_PlaceNewConstructable_Protected_Virtual_Constructable_GridBased_0;

		// Token: 0x0400464A RID: 17994
		private static readonly IntPtr NativeMethodInfoPtr_CompletePowerLine_Private_Void_PowerNode_0;

		// Token: 0x0400464B RID: 17995
		private static readonly IntPtr NativeMethodInfoPtr_StopCreatingPowerLine_Private_Void_0;

		// Token: 0x0400464C RID: 17996
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
