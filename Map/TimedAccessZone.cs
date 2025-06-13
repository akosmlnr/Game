using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Map
{
	// Token: 0x020007B3 RID: 1971
	public class TimedAccessZone : AccessZone
	{
		// Token: 0x0600BA6F RID: 47727 RVA: 0x002E73C0 File Offset: 0x002E55C0
		// Note: this type is marked as 'beforefieldinit'.
		static TimedAccessZone()
		{
			Il2CppClassPointerStore<TimedAccessZone>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map", "TimedAccessZone");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimedAccessZone>.NativeClassPtr);
			TimedAccessZone.NativeFieldInfoPtr_OpenTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimedAccessZone>.NativeClassPtr, "OpenTime");
			TimedAccessZone.NativeFieldInfoPtr_CloseTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimedAccessZone>.NativeClassPtr, "CloseTime");
			TimedAccessZone.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimedAccessZone>.NativeClassPtr, 100686363);
			TimedAccessZone.NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimedAccessZone>.NativeClassPtr, 100686364);
			TimedAccessZone.NativeMethodInfoPtr_GetIsOpen_Protected_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimedAccessZone>.NativeClassPtr, 100686365);
			TimedAccessZone.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimedAccessZone>.NativeClassPtr, 100686366);
		}

		// Token: 0x0600BA70 RID: 47728 RVA: 0x002E7468 File Offset: 0x002E5668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317339, XrefRangeEnd = 317355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TimedAccessZone.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BA71 RID: 47729 RVA: 0x002E74A4 File Offset: 0x002E56A4
		[CallerCount(0)]
		public unsafe virtual void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TimedAccessZone.NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BA72 RID: 47730 RVA: 0x002E74E0 File Offset: 0x002E56E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317355, XrefRangeEnd = 317361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool GetIsOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TimedAccessZone.NativeMethodInfoPtr_GetIsOpen_Protected_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600BA73 RID: 47731 RVA: 0x002E7528 File Offset: 0x002E5728
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimedAccessZone() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimedAccessZone>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimedAccessZone.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BA74 RID: 47732 RVA: 0x0005B2DC File Offset: 0x000594DC
		public TimedAccessZone(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003986 RID: 14726
		// (get) Token: 0x0600BA75 RID: 47733 RVA: 0x002E7564 File Offset: 0x002E5764
		// (set) Token: 0x0600BA76 RID: 47734 RVA: 0x0005B2E5 File Offset: 0x000594E5
		public unsafe int OpenTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimedAccessZone.NativeFieldInfoPtr_OpenTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimedAccessZone.NativeFieldInfoPtr_OpenTime)) = value;
			}
		}

		// Token: 0x17003987 RID: 14727
		// (get) Token: 0x0600BA77 RID: 47735 RVA: 0x002E758C File Offset: 0x002E578C
		// (set) Token: 0x0600BA78 RID: 47736 RVA: 0x0005B300 File Offset: 0x00059500
		public unsafe int CloseTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimedAccessZone.NativeFieldInfoPtr_CloseTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimedAccessZone.NativeFieldInfoPtr_CloseTime)) = value;
			}
		}

		// Token: 0x04007DB9 RID: 32185
		private static readonly IntPtr NativeFieldInfoPtr_OpenTime;

		// Token: 0x04007DBA RID: 32186
		private static readonly IntPtr NativeFieldInfoPtr_CloseTime;

		// Token: 0x04007DBB RID: 32187
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04007DBC RID: 32188
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_0;

		// Token: 0x04007DBD RID: 32189
		private static readonly IntPtr NativeMethodInfoPtr_GetIsOpen_Protected_Virtual_New_Boolean_0;

		// Token: 0x04007DBE RID: 32190
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
