using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.PlayerTasks;
using UnityEngine;

namespace Il2CppScheduleOne.StationFramework
{
	// Token: 0x020005B3 RID: 1459
	public class PourableModule : ItemModule
	{
		// Token: 0x06007F51 RID: 32593 RVA: 0x00224364 File Offset: 0x00222564
		// Note: this type is marked as 'beforefieldinit'.
		static PourableModule()
		{
			Il2CppClassPointerStore<PourableModule>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.StationFramework", "PourableModule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PourableModule>.NativeClassPtr);
			PourableModule.NativeFieldInfoPtr__IsPouring_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, "<IsPouring>k__BackingField");
			PourableModule.NativeFieldInfoPtr__NormalizedPourRate_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, "<NormalizedPourRate>k__BackingField");
			PourableModule.NativeFieldInfoPtr__LiquidLevel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, "<LiquidLevel>k__BackingField");
			PourableModule.NativeFieldInfoPtr_LiquidType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, "LiquidType");
			PourableModule.NativeFieldInfoPtr_PourRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, "PourRate");
			PourableModule.NativeFieldInfoPtr_AngleFromUpToPour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, "AngleFromUpToPour");
			PourableModule.NativeFieldInfoPtr_OnlyEmptyOverFillable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, "OnlyEmptyOverFillable");
			PourableModule.NativeFieldInfoPtr_LiquidCapacity_L = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, "LiquidCapacity_L");
			PourableModule.NativeFieldInfoPtr_LiquidColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, "LiquidColor");
			PourableModule.NativeFieldInfoPtr_DefaultLiquid_L = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, "DefaultLiquid_L");
			PourableModule.NativeFieldInfoPtr_PourParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, "PourParticles");
			PourableModule.NativeFieldInfoPtr_PourPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, "PourPoint");
			PourableModule.NativeFieldInfoPtr_LiquidContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, "LiquidContainer");
			PourableModule.NativeFieldInfoPtr_Draggable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, "Draggable");
			PourableModule.NativeFieldInfoPtr_DraggableConstraint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, "DraggableConstraint");
			PourableModule.NativeFieldInfoPtr_PourSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, "PourSound");
			PourableModule.NativeFieldInfoPtr_PourParticlesColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, "PourParticlesColor");
			PourableModule.NativeFieldInfoPtr_ParticleMinMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, "ParticleMinMultiplier");
			PourableModule.NativeFieldInfoPtr_ParticleMaxMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, "ParticleMaxMultiplier");
			PourableModule.NativeFieldInfoPtr_particleMinSizes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, "particleMinSizes");
			PourableModule.NativeFieldInfoPtr_particleMaxSizes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, "particleMaxSizes");
			PourableModule.NativeFieldInfoPtr_activeFillable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, "activeFillable");
			PourableModule.NativeFieldInfoPtr_timeSinceFillableHit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, "timeSinceFillableHit");
			PourableModule.NativeMethodInfoPtr_get_IsPouring_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, 100679330);
			PourableModule.NativeMethodInfoPtr_set_IsPouring_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, 100679331);
			PourableModule.NativeMethodInfoPtr_get_NormalizedPourRate_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, 100679332);
			PourableModule.NativeMethodInfoPtr_set_NormalizedPourRate_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, 100679333);
			PourableModule.NativeMethodInfoPtr_get_LiquidLevel_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, 100679334);
			PourableModule.NativeMethodInfoPtr_set_LiquidLevel_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, 100679335);
			PourableModule.NativeMethodInfoPtr_get_NormalizedLiquidLevel_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, 100679336);
			PourableModule.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, 100679337);
			PourableModule.NativeMethodInfoPtr_ActivateModule_Public_Virtual_Void_StationItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, 100679338);
			PourableModule.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, 100679339);
			PourableModule.NativeMethodInfoPtr_UpdatePouring_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, 100679340);
			PourableModule.NativeMethodInfoPtr_UpdatePourSound_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, 100679341);
			PourableModule.NativeMethodInfoPtr_ChangeLiquidLevel_Public_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, 100679342);
			PourableModule.NativeMethodInfoPtr_SetLiquidLevel_Public_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, 100679343);
			PourableModule.NativeMethodInfoPtr_PourAmount_Protected_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, 100679344);
			PourableModule.NativeMethodInfoPtr_ParticleCollision_Private_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, 100679345);
			PourableModule.NativeMethodInfoPtr_CanPour_Protected_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, 100679346);
			PourableModule.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, 100679347);
		}

		// Token: 0x17002665 RID: 9829
		// (get) Token: 0x06007F52 RID: 32594 RVA: 0x002246C8 File Offset: 0x002228C8
		// (set) Token: 0x06007F53 RID: 32595 RVA: 0x00224704 File Offset: 0x00222904
		public unsafe bool IsPouring
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PourableModule.NativeMethodInfoPtr_get_IsPouring_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableModule.NativeMethodInfoPtr_set_IsPouring_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002666 RID: 9830
		// (get) Token: 0x06007F54 RID: 32596 RVA: 0x00224744 File Offset: 0x00222944
		// (set) Token: 0x06007F55 RID: 32597 RVA: 0x00224780 File Offset: 0x00222980
		public unsafe float NormalizedPourRate
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PourableModule.NativeMethodInfoPtr_get_NormalizedPourRate_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableModule.NativeMethodInfoPtr_set_NormalizedPourRate_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002667 RID: 9831
		// (get) Token: 0x06007F56 RID: 32598 RVA: 0x002247C0 File Offset: 0x002229C0
		// (set) Token: 0x06007F57 RID: 32599 RVA: 0x002247FC File Offset: 0x002229FC
		public unsafe float LiquidLevel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PourableModule.NativeMethodInfoPtr_get_LiquidLevel_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 51528, RefRangeEnd = 51531, XrefRangeStart = 51528, XrefRangeEnd = 51531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableModule.NativeMethodInfoPtr_set_LiquidLevel_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002668 RID: 9832
		// (get) Token: 0x06007F58 RID: 32600 RVA: 0x0022483C File Offset: 0x00222A3C
		public unsafe float NormalizedLiquidLevel
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 241558, RefRangeEnd = 241563, XrefRangeStart = 241558, XrefRangeEnd = 241558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PourableModule.NativeMethodInfoPtr_get_NormalizedLiquidLevel_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x06007F59 RID: 32601 RVA: 0x00224878 File Offset: 0x00222A78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241563, XrefRangeEnd = 241603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourableModule.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007F5A RID: 32602 RVA: 0x002248B4 File Offset: 0x00222AB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241603, XrefRangeEnd = 241614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ActivateModule(StationItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourableModule.NativeMethodInfoPtr_ActivateModule_Public_Virtual_Void_StationItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007F5B RID: 32603 RVA: 0x00224904 File Offset: 0x00222B04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241614, XrefRangeEnd = 241622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourableModule.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007F5C RID: 32604 RVA: 0x00224940 File Offset: 0x00222B40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241622, XrefRangeEnd = 241648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdatePouring()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourableModule.NativeMethodInfoPtr_UpdatePouring_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007F5D RID: 32605 RVA: 0x0022497C File Offset: 0x00222B7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241648, XrefRangeEnd = 241654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdatePourSound()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableModule.NativeMethodInfoPtr_UpdatePourSound_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007F5E RID: 32606 RVA: 0x002249B0 File Offset: 0x00222BB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241654, XrefRangeEnd = 241660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ChangeLiquidLevel(float change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref change;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourableModule.NativeMethodInfoPtr_ChangeLiquidLevel_Public_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007F5F RID: 32607 RVA: 0x002249FC File Offset: 0x00222BFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241660, XrefRangeEnd = 241666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetLiquidLevel(float level)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref level;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourableModule.NativeMethodInfoPtr_SetLiquidLevel_Public_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007F60 RID: 32608 RVA: 0x00224A48 File Offset: 0x00222C48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241666, XrefRangeEnd = 241684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PourAmount(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourableModule.NativeMethodInfoPtr_PourAmount_Protected_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007F61 RID: 32609 RVA: 0x00224A94 File Offset: 0x00222C94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241684, XrefRangeEnd = 241693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParticleCollision(GameObject other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableModule.NativeMethodInfoPtr_ParticleCollision_Private_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007F62 RID: 32610 RVA: 0x00224AD8 File Offset: 0x00222CD8
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 31612, RefRangeEnd = 31633, XrefRangeStart = 31612, XrefRangeEnd = 31633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanPour()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourableModule.NativeMethodInfoPtr_CanPour_Protected_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06007F63 RID: 32611 RVA: 0x00224B20 File Offset: 0x00222D20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241693, XrefRangeEnd = 241698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PourableModule() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PourableModule>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableModule.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007F64 RID: 32612 RVA: 0x0003C375 File Offset: 0x0003A575
		public PourableModule(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700264E RID: 9806
		// (get) Token: 0x06007F65 RID: 32613 RVA: 0x00224B5C File Offset: 0x00222D5C
		// (set) Token: 0x06007F66 RID: 32614 RVA: 0x0003C37E File Offset: 0x0003A57E
		public unsafe bool _IsPouring_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr__IsPouring_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr__IsPouring_k__BackingField)) = value;
			}
		}

		// Token: 0x1700264F RID: 9807
		// (get) Token: 0x06007F67 RID: 32615 RVA: 0x00224B84 File Offset: 0x00222D84
		// (set) Token: 0x06007F68 RID: 32616 RVA: 0x0003C399 File Offset: 0x0003A599
		public unsafe float _NormalizedPourRate_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr__NormalizedPourRate_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr__NormalizedPourRate_k__BackingField)) = value;
			}
		}

		// Token: 0x17002650 RID: 9808
		// (get) Token: 0x06007F69 RID: 32617 RVA: 0x00224BAC File Offset: 0x00222DAC
		// (set) Token: 0x06007F6A RID: 32618 RVA: 0x0003C3B4 File Offset: 0x0003A5B4
		public unsafe float _LiquidLevel_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr__LiquidLevel_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr__LiquidLevel_k__BackingField)) = value;
			}
		}

		// Token: 0x17002651 RID: 9809
		// (get) Token: 0x06007F6B RID: 32619 RVA: 0x00224BD4 File Offset: 0x00222DD4
		// (set) Token: 0x06007F6C RID: 32620 RVA: 0x0003C3CF File Offset: 0x0003A5CF
		public unsafe string LiquidType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_LiquidType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_LiquidType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002652 RID: 9810
		// (get) Token: 0x06007F6D RID: 32621 RVA: 0x00224BFC File Offset: 0x00222DFC
		// (set) Token: 0x06007F6E RID: 32622 RVA: 0x0003C3EE File Offset: 0x0003A5EE
		public unsafe float PourRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_PourRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_PourRate)) = value;
			}
		}

		// Token: 0x17002653 RID: 9811
		// (get) Token: 0x06007F6F RID: 32623 RVA: 0x00224C24 File Offset: 0x00222E24
		// (set) Token: 0x06007F70 RID: 32624 RVA: 0x0003C409 File Offset: 0x0003A609
		public unsafe float AngleFromUpToPour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_AngleFromUpToPour);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_AngleFromUpToPour)) = value;
			}
		}

		// Token: 0x17002654 RID: 9812
		// (get) Token: 0x06007F71 RID: 32625 RVA: 0x00224C4C File Offset: 0x00222E4C
		// (set) Token: 0x06007F72 RID: 32626 RVA: 0x0003C424 File Offset: 0x0003A624
		public unsafe bool OnlyEmptyOverFillable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_OnlyEmptyOverFillable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_OnlyEmptyOverFillable)) = value;
			}
		}

		// Token: 0x17002655 RID: 9813
		// (get) Token: 0x06007F73 RID: 32627 RVA: 0x00224C74 File Offset: 0x00222E74
		// (set) Token: 0x06007F74 RID: 32628 RVA: 0x0003C43F File Offset: 0x0003A63F
		public unsafe float LiquidCapacity_L
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_LiquidCapacity_L);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_LiquidCapacity_L)) = value;
			}
		}

		// Token: 0x17002656 RID: 9814
		// (get) Token: 0x06007F75 RID: 32629 RVA: 0x00224C9C File Offset: 0x00222E9C
		// (set) Token: 0x06007F76 RID: 32630 RVA: 0x0003C45A File Offset: 0x0003A65A
		public unsafe Color LiquidColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_LiquidColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_LiquidColor)) = value;
			}
		}

		// Token: 0x17002657 RID: 9815
		// (get) Token: 0x06007F77 RID: 32631 RVA: 0x00224CC4 File Offset: 0x00222EC4
		// (set) Token: 0x06007F78 RID: 32632 RVA: 0x0003C475 File Offset: 0x0003A675
		public unsafe float DefaultLiquid_L
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_DefaultLiquid_L);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_DefaultLiquid_L)) = value;
			}
		}

		// Token: 0x17002658 RID: 9816
		// (get) Token: 0x06007F79 RID: 32633 RVA: 0x00224CEC File Offset: 0x00222EEC
		// (set) Token: 0x06007F7A RID: 32634 RVA: 0x0003C490 File Offset: 0x0003A690
		public unsafe Il2CppReferenceArray<ParticleSystem> PourParticles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_PourParticles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ParticleSystem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_PourParticles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002659 RID: 9817
		// (get) Token: 0x06007F7B RID: 32635 RVA: 0x00224D1C File Offset: 0x00222F1C
		// (set) Token: 0x06007F7C RID: 32636 RVA: 0x0003C4AF File Offset: 0x0003A6AF
		public unsafe Transform PourPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_PourPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_PourPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700265A RID: 9818
		// (get) Token: 0x06007F7D RID: 32637 RVA: 0x00224D4C File Offset: 0x00222F4C
		// (set) Token: 0x06007F7E RID: 32638 RVA: 0x0003C4CE File Offset: 0x0003A6CE
		public unsafe LiquidContainer LiquidContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_LiquidContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LiquidContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_LiquidContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700265B RID: 9819
		// (get) Token: 0x06007F7F RID: 32639 RVA: 0x00224D7C File Offset: 0x00222F7C
		// (set) Token: 0x06007F80 RID: 32640 RVA: 0x0003C4ED File Offset: 0x0003A6ED
		public unsafe Draggable Draggable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_Draggable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Draggable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_Draggable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700265C RID: 9820
		// (get) Token: 0x06007F81 RID: 32641 RVA: 0x00224DAC File Offset: 0x00222FAC
		// (set) Token: 0x06007F82 RID: 32642 RVA: 0x0003C50C File Offset: 0x0003A70C
		public unsafe DraggableConstraint DraggableConstraint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_DraggableConstraint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DraggableConstraint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_DraggableConstraint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700265D RID: 9821
		// (get) Token: 0x06007F83 RID: 32643 RVA: 0x00224DDC File Offset: 0x00222FDC
		// (set) Token: 0x06007F84 RID: 32644 RVA: 0x0003C52B File Offset: 0x0003A72B
		public unsafe AudioSourceController PourSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_PourSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_PourSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700265E RID: 9822
		// (get) Token: 0x06007F85 RID: 32645 RVA: 0x00224E0C File Offset: 0x0022300C
		// (set) Token: 0x06007F86 RID: 32646 RVA: 0x0003C54A File Offset: 0x0003A74A
		public unsafe Color PourParticlesColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_PourParticlesColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_PourParticlesColor)) = value;
			}
		}

		// Token: 0x1700265F RID: 9823
		// (get) Token: 0x06007F87 RID: 32647 RVA: 0x00224E34 File Offset: 0x00223034
		// (set) Token: 0x06007F88 RID: 32648 RVA: 0x0003C565 File Offset: 0x0003A765
		public unsafe float ParticleMinMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_ParticleMinMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_ParticleMinMultiplier)) = value;
			}
		}

		// Token: 0x17002660 RID: 9824
		// (get) Token: 0x06007F89 RID: 32649 RVA: 0x00224E5C File Offset: 0x0022305C
		// (set) Token: 0x06007F8A RID: 32650 RVA: 0x0003C580 File Offset: 0x0003A780
		public unsafe float ParticleMaxMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_ParticleMaxMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_ParticleMaxMultiplier)) = value;
			}
		}

		// Token: 0x17002661 RID: 9825
		// (get) Token: 0x06007F8B RID: 32651 RVA: 0x00224E84 File Offset: 0x00223084
		// (set) Token: 0x06007F8C RID: 32652 RVA: 0x0003C59B File Offset: 0x0003A79B
		public unsafe Il2CppStructArray<float> particleMinSizes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_particleMinSizes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_particleMinSizes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002662 RID: 9826
		// (get) Token: 0x06007F8D RID: 32653 RVA: 0x00224EB4 File Offset: 0x002230B4
		// (set) Token: 0x06007F8E RID: 32654 RVA: 0x0003C5BA File Offset: 0x0003A7BA
		public unsafe Il2CppStructArray<float> particleMaxSizes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_particleMaxSizes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_particleMaxSizes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002663 RID: 9827
		// (get) Token: 0x06007F8F RID: 32655 RVA: 0x00224EE4 File Offset: 0x002230E4
		// (set) Token: 0x06007F90 RID: 32656 RVA: 0x0003C5D9 File Offset: 0x0003A7D9
		public unsafe Fillable activeFillable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_activeFillable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Fillable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_activeFillable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002664 RID: 9828
		// (get) Token: 0x06007F91 RID: 32657 RVA: 0x00224F14 File Offset: 0x00223114
		// (set) Token: 0x06007F92 RID: 32658 RVA: 0x0003C5F8 File Offset: 0x0003A7F8
		public unsafe float timeSinceFillableHit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_timeSinceFillableHit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_timeSinceFillableHit)) = value;
			}
		}

		// Token: 0x040056A6 RID: 22182
		private static readonly IntPtr NativeFieldInfoPtr__IsPouring_k__BackingField;

		// Token: 0x040056A7 RID: 22183
		private static readonly IntPtr NativeFieldInfoPtr__NormalizedPourRate_k__BackingField;

		// Token: 0x040056A8 RID: 22184
		private static readonly IntPtr NativeFieldInfoPtr__LiquidLevel_k__BackingField;

		// Token: 0x040056A9 RID: 22185
		private static readonly IntPtr NativeFieldInfoPtr_LiquidType;

		// Token: 0x040056AA RID: 22186
		private static readonly IntPtr NativeFieldInfoPtr_PourRate;

		// Token: 0x040056AB RID: 22187
		private static readonly IntPtr NativeFieldInfoPtr_AngleFromUpToPour;

		// Token: 0x040056AC RID: 22188
		private static readonly IntPtr NativeFieldInfoPtr_OnlyEmptyOverFillable;

		// Token: 0x040056AD RID: 22189
		private static readonly IntPtr NativeFieldInfoPtr_LiquidCapacity_L;

		// Token: 0x040056AE RID: 22190
		private static readonly IntPtr NativeFieldInfoPtr_LiquidColor;

		// Token: 0x040056AF RID: 22191
		private static readonly IntPtr NativeFieldInfoPtr_DefaultLiquid_L;

		// Token: 0x040056B0 RID: 22192
		private static readonly IntPtr NativeFieldInfoPtr_PourParticles;

		// Token: 0x040056B1 RID: 22193
		private static readonly IntPtr NativeFieldInfoPtr_PourPoint;

		// Token: 0x040056B2 RID: 22194
		private static readonly IntPtr NativeFieldInfoPtr_LiquidContainer;

		// Token: 0x040056B3 RID: 22195
		private static readonly IntPtr NativeFieldInfoPtr_Draggable;

		// Token: 0x040056B4 RID: 22196
		private static readonly IntPtr NativeFieldInfoPtr_DraggableConstraint;

		// Token: 0x040056B5 RID: 22197
		private static readonly IntPtr NativeFieldInfoPtr_PourSound;

		// Token: 0x040056B6 RID: 22198
		private static readonly IntPtr NativeFieldInfoPtr_PourParticlesColor;

		// Token: 0x040056B7 RID: 22199
		private static readonly IntPtr NativeFieldInfoPtr_ParticleMinMultiplier;

		// Token: 0x040056B8 RID: 22200
		private static readonly IntPtr NativeFieldInfoPtr_ParticleMaxMultiplier;

		// Token: 0x040056B9 RID: 22201
		private static readonly IntPtr NativeFieldInfoPtr_particleMinSizes;

		// Token: 0x040056BA RID: 22202
		private static readonly IntPtr NativeFieldInfoPtr_particleMaxSizes;

		// Token: 0x040056BB RID: 22203
		private static readonly IntPtr NativeFieldInfoPtr_activeFillable;

		// Token: 0x040056BC RID: 22204
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceFillableHit;

		// Token: 0x040056BD RID: 22205
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPouring_Public_get_Boolean_0;

		// Token: 0x040056BE RID: 22206
		private static readonly IntPtr NativeMethodInfoPtr_set_IsPouring_Protected_set_Void_Boolean_0;

		// Token: 0x040056BF RID: 22207
		private static readonly IntPtr NativeMethodInfoPtr_get_NormalizedPourRate_Public_get_Single_0;

		// Token: 0x040056C0 RID: 22208
		private static readonly IntPtr NativeMethodInfoPtr_set_NormalizedPourRate_Private_set_Void_Single_0;

		// Token: 0x040056C1 RID: 22209
		private static readonly IntPtr NativeMethodInfoPtr_get_LiquidLevel_Public_get_Single_0;

		// Token: 0x040056C2 RID: 22210
		private static readonly IntPtr NativeMethodInfoPtr_set_LiquidLevel_Protected_set_Void_Single_0;

		// Token: 0x040056C3 RID: 22211
		private static readonly IntPtr NativeMethodInfoPtr_get_NormalizedLiquidLevel_Public_get_Single_0;

		// Token: 0x040056C4 RID: 22212
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x040056C5 RID: 22213
		private static readonly IntPtr NativeMethodInfoPtr_ActivateModule_Public_Virtual_Void_StationItem_0;

		// Token: 0x040056C6 RID: 22214
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x040056C7 RID: 22215
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePouring_Protected_Virtual_New_Void_0;

		// Token: 0x040056C8 RID: 22216
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePourSound_Private_Void_0;

		// Token: 0x040056C9 RID: 22217
		private static readonly IntPtr NativeMethodInfoPtr_ChangeLiquidLevel_Public_Virtual_New_Void_Single_0;

		// Token: 0x040056CA RID: 22218
		private static readonly IntPtr NativeMethodInfoPtr_SetLiquidLevel_Public_Virtual_New_Void_Single_0;

		// Token: 0x040056CB RID: 22219
		private static readonly IntPtr NativeMethodInfoPtr_PourAmount_Protected_Virtual_New_Void_Single_0;

		// Token: 0x040056CC RID: 22220
		private static readonly IntPtr NativeMethodInfoPtr_ParticleCollision_Private_Void_GameObject_0;

		// Token: 0x040056CD RID: 22221
		private static readonly IntPtr NativeMethodInfoPtr_CanPour_Protected_Virtual_New_Boolean_0;

		// Token: 0x040056CE RID: 22222
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
