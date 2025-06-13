using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Vehicles.AI
{
	// Token: 0x02000528 RID: 1320
	public class SteerPID : Il2CppSystem.Object
	{
		// Token: 0x0600732E RID: 29486 RVA: 0x001FB584 File Offset: 0x001F9784
		// Note: this type is marked as 'beforefieldinit'.
		static SteerPID()
		{
			Il2CppClassPointerStore<SteerPID>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles.AI", "SteerPID");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteerPID>.NativeClassPtr);
			SteerPID.NativeFieldInfoPtr_error_old = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteerPID>.NativeClassPtr, "error_old");
			SteerPID.NativeFieldInfoPtr_error_sum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteerPID>.NativeClassPtr, "error_sum");
			SteerPID.NativeMethodInfoPtr_GetNewValue_Public_Single_Single_PID_Parameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteerPID>.NativeClassPtr, 100677871);
			SteerPID.NativeMethodInfoPtr_AddValueToAverage_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteerPID>.NativeClassPtr, 100677872);
			SteerPID.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteerPID>.NativeClassPtr, 100677873);
		}

		// Token: 0x0600732F RID: 29487 RVA: 0x001FB618 File Offset: 0x001F9818
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226434, XrefRangeEnd = 226436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetNewValue(float error, PID_Parameters pid_parameters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref error;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref pid_parameters;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(SteerPID.NativeMethodInfoPtr_GetNewValue_Public_Single_Single_PID_Parameters_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06007330 RID: 29488 RVA: 0x001FB670 File Offset: 0x001F9870
		[CallerCount(0)]
		public unsafe static float AddValueToAverage(float oldAverage, float valueToAdd, float count)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref oldAverage;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref valueToAdd;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref count;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(SteerPID.NativeMethodInfoPtr_AddValueToAverage_Public_Static_Single_Single_Single_Single_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06007331 RID: 29489 RVA: 0x001FB6CC File Offset: 0x001F98CC
		[CallerCount(2576)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SteerPID() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteerPID>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteerPID.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007332 RID: 29490 RVA: 0x000367A4 File Offset: 0x000349A4
		public SteerPID(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700229D RID: 8861
		// (get) Token: 0x06007333 RID: 29491 RVA: 0x001FB708 File Offset: 0x001F9908
		// (set) Token: 0x06007334 RID: 29492 RVA: 0x000367AD File Offset: 0x000349AD
		public unsafe float error_old
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SteerPID.NativeFieldInfoPtr_error_old);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SteerPID.NativeFieldInfoPtr_error_old)) = value;
			}
		}

		// Token: 0x1700229E RID: 8862
		// (get) Token: 0x06007335 RID: 29493 RVA: 0x001FB730 File Offset: 0x001F9930
		// (set) Token: 0x06007336 RID: 29494 RVA: 0x000367C8 File Offset: 0x000349C8
		public unsafe float error_sum
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SteerPID.NativeFieldInfoPtr_error_sum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SteerPID.NativeFieldInfoPtr_error_sum)) = value;
			}
		}

		// Token: 0x04004EA8 RID: 20136
		private static readonly System.IntPtr NativeFieldInfoPtr_error_old;

		// Token: 0x04004EA9 RID: 20137
		private static readonly System.IntPtr NativeFieldInfoPtr_error_sum;

		// Token: 0x04004EAA RID: 20138
		private static readonly System.IntPtr NativeMethodInfoPtr_GetNewValue_Public_Single_Single_PID_Parameters_0;

		// Token: 0x04004EAB RID: 20139
		private static readonly System.IntPtr NativeMethodInfoPtr_AddValueToAverage_Public_Static_Single_Single_Single_Single_0;

		// Token: 0x04004EAC RID: 20140
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
