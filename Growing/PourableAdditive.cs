using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.PlayerTasks;
using UnityEngine;

namespace Il2CppScheduleOne.Growing
{
	// Token: 0x0200057F RID: 1407
	public class PourableAdditive : Pourable
	{
		// Token: 0x06007ABA RID: 31418 RVA: 0x002145C8 File Offset: 0x002127C8
		// Note: this type is marked as 'beforefieldinit'.
		static PourableAdditive()
		{
			Il2CppClassPointerStore<PourableAdditive>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Growing", "PourableAdditive");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PourableAdditive>.NativeClassPtr);
			PourableAdditive.NativeFieldInfoPtr_NormalizedAmountForSuccess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableAdditive>.NativeClassPtr, "NormalizedAmountForSuccess");
			PourableAdditive.NativeFieldInfoPtr_AdditiveDefinition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableAdditive>.NativeClassPtr, "AdditiveDefinition");
			PourableAdditive.NativeFieldInfoPtr_LiquidColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableAdditive>.NativeClassPtr, "LiquidColor");
			PourableAdditive.NativeFieldInfoPtr_pouredAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableAdditive>.NativeClassPtr, "pouredAmount");
			PourableAdditive.NativeMethodInfoPtr_PourAmount_Protected_Virtual_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableAdditive>.NativeClassPtr, 100678785);
			PourableAdditive.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableAdditive>.NativeClassPtr, 100678786);
		}

		// Token: 0x06007ABB RID: 31419 RVA: 0x00214670 File Offset: 0x00212870
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236386, XrefRangeEnd = 236387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PourAmount(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourableAdditive.NativeMethodInfoPtr_PourAmount_Protected_Virtual_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007ABC RID: 31420 RVA: 0x002146BC File Offset: 0x002128BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236387, XrefRangeEnd = 236388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PourableAdditive() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PourableAdditive>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableAdditive.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007ABD RID: 31421 RVA: 0x00039FF8 File Offset: 0x000381F8
		public PourableAdditive(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170024EA RID: 9450
		// (get) Token: 0x06007ABE RID: 31422 RVA: 0x002146F8 File Offset: 0x002128F8
		// (set) Token: 0x06007ABF RID: 31423 RVA: 0x0003A001 File Offset: 0x00038201
		public unsafe static float NormalizedAmountForSuccess
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PourableAdditive.NativeFieldInfoPtr_NormalizedAmountForSuccess, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PourableAdditive.NativeFieldInfoPtr_NormalizedAmountForSuccess, (void*)(&value));
			}
		}

		// Token: 0x170024EB RID: 9451
		// (get) Token: 0x06007AC0 RID: 31424 RVA: 0x00214714 File Offset: 0x00212914
		// (set) Token: 0x06007AC1 RID: 31425 RVA: 0x0003A00F File Offset: 0x0003820F
		public unsafe AdditiveDefinition AdditiveDefinition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableAdditive.NativeFieldInfoPtr_AdditiveDefinition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdditiveDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableAdditive.NativeFieldInfoPtr_AdditiveDefinition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024EC RID: 9452
		// (get) Token: 0x06007AC2 RID: 31426 RVA: 0x00214744 File Offset: 0x00212944
		// (set) Token: 0x06007AC3 RID: 31427 RVA: 0x0003A02E File Offset: 0x0003822E
		public unsafe Color LiquidColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableAdditive.NativeFieldInfoPtr_LiquidColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableAdditive.NativeFieldInfoPtr_LiquidColor)) = value;
			}
		}

		// Token: 0x170024ED RID: 9453
		// (get) Token: 0x06007AC4 RID: 31428 RVA: 0x0021476C File Offset: 0x0021296C
		// (set) Token: 0x06007AC5 RID: 31429 RVA: 0x0003A049 File Offset: 0x00038249
		public unsafe float pouredAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableAdditive.NativeFieldInfoPtr_pouredAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableAdditive.NativeFieldInfoPtr_pouredAmount)) = value;
			}
		}

		// Token: 0x0400539E RID: 21406
		private static readonly IntPtr NativeFieldInfoPtr_NormalizedAmountForSuccess;

		// Token: 0x0400539F RID: 21407
		private static readonly IntPtr NativeFieldInfoPtr_AdditiveDefinition;

		// Token: 0x040053A0 RID: 21408
		private static readonly IntPtr NativeFieldInfoPtr_LiquidColor;

		// Token: 0x040053A1 RID: 21409
		private static readonly IntPtr NativeFieldInfoPtr_pouredAmount;

		// Token: 0x040053A2 RID: 21410
		private static readonly IntPtr NativeMethodInfoPtr_PourAmount_Protected_Virtual_Void_Single_0;

		// Token: 0x040053A3 RID: 21411
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
