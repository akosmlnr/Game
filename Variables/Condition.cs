using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Variables
{
	// Token: 0x02000188 RID: 392
	[System.Serializable]
	public class Condition : Il2CppSystem.Object
	{
		// Token: 0x06001EFE RID: 7934 RVA: 0x000D3E48 File Offset: 0x000D2048
		// Note: this type is marked as 'beforefieldinit'.
		static Condition()
		{
			Il2CppClassPointerStore<Condition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Variables", "Condition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Condition>.NativeClassPtr);
			Condition.NativeFieldInfoPtr_VariableName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Condition>.NativeClassPtr, "VariableName");
			Condition.NativeFieldInfoPtr_Operator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Condition>.NativeClassPtr, "Operator");
			Condition.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Condition>.NativeClassPtr, "Value");
			Condition.NativeMethodInfoPtr_Evaluate_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Condition>.NativeClassPtr, 100666844);
			Condition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Condition>.NativeClassPtr, 100666845);
		}

		// Token: 0x06001EFF RID: 7935 RVA: 0x000D3EDC File Offset: 0x000D20DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110876, XrefRangeEnd = 110893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Evaluate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Condition.NativeMethodInfoPtr_Evaluate_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06001F00 RID: 7936 RVA: 0x000D3F18 File Offset: 0x000D2118
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110893, XrefRangeEnd = 110902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Condition() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Condition>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Condition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001F01 RID: 7937 RVA: 0x000115BA File Offset: 0x0000F7BA
		public Condition(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000A98 RID: 2712
		// (get) Token: 0x06001F02 RID: 7938 RVA: 0x000D3F54 File Offset: 0x000D2154
		// (set) Token: 0x06001F03 RID: 7939 RVA: 0x000115C3 File Offset: 0x0000F7C3
		public unsafe string VariableName
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Condition.NativeFieldInfoPtr_VariableName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Condition.NativeFieldInfoPtr_VariableName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A99 RID: 2713
		// (get) Token: 0x06001F04 RID: 7940 RVA: 0x000D3F7C File Offset: 0x000D217C
		// (set) Token: 0x06001F05 RID: 7941 RVA: 0x000115E2 File Offset: 0x0000F7E2
		public unsafe Condition.EConditionType Operator
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Condition.NativeFieldInfoPtr_Operator);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Condition.NativeFieldInfoPtr_Operator)) = value;
			}
		}

		// Token: 0x17000A9A RID: 2714
		// (get) Token: 0x06001F06 RID: 7942 RVA: 0x000D3FA4 File Offset: 0x000D21A4
		// (set) Token: 0x06001F07 RID: 7943 RVA: 0x000115FD File Offset: 0x0000F7FD
		public unsafe string Value
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Condition.NativeFieldInfoPtr_Value);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Condition.NativeFieldInfoPtr_Value), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400149C RID: 5276
		private static readonly System.IntPtr NativeFieldInfoPtr_VariableName;

		// Token: 0x0400149D RID: 5277
		private static readonly System.IntPtr NativeFieldInfoPtr_Operator;

		// Token: 0x0400149E RID: 5278
		private static readonly System.IntPtr NativeFieldInfoPtr_Value;

		// Token: 0x0400149F RID: 5279
		private static readonly System.IntPtr NativeMethodInfoPtr_Evaluate_Public_Boolean_0;

		// Token: 0x040014A0 RID: 5280
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020008DF RID: 2271
		[OriginalName("Assembly-CSharp.dll", "", "EConditionType")]
		public enum EConditionType
		{
			// Token: 0x04008743 RID: 34627
			GreaterThan,
			// Token: 0x04008744 RID: 34628
			LessThan,
			// Token: 0x04008745 RID: 34629
			EqualTo,
			// Token: 0x04008746 RID: 34630
			NotEqualTo,
			// Token: 0x04008747 RID: 34631
			GreaterThanOrEqualTo,
			// Token: 0x04008748 RID: 34632
			LessThanOrEqualTo
		}
	}
}
