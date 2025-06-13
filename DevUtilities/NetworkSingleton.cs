using System;
using Il2CppFishNet.Object;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x02000480 RID: 1152
	public class NetworkSingleton<T> : NetworkBehaviour where T : NetworkSingleton<T>
	{
		// Token: 0x060062EF RID: 25327 RVA: 0x001C5784 File Offset: 0x001C3984
		// Note: this type is marked as 'beforefieldinit'.
		static NetworkSingleton()
		{
			Il2CppClassPointerStore<NetworkSingleton<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "NetworkSingleton`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[]
			{
				Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetworkSingleton<T>>.NativeClassPtr);
			NetworkSingleton<T>.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkSingleton<T>>.NativeClassPtr, "instance");
			NetworkSingleton<T>.NativeFieldInfoPtr_Destroyed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkSingleton<T>>.NativeClassPtr, "Destroyed");
			NetworkSingleton<T>.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkSingleton<T>>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.DevUtilities.NetworkSingleton`1Assembly-CSharp.dll_Excuted");
			NetworkSingleton<T>.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkSingleton<T>>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.DevUtilities.NetworkSingleton`1Assembly-CSharp.dll_Excuted");
			NetworkSingleton<T>.NativeMethodInfoPtr_get_InstanceExists_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSingleton<T>>.NativeClassPtr, 100675974);
			NetworkSingleton<T>.NativeMethodInfoPtr_get_Instance_Public_Static_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSingleton<T>>.NativeClassPtr, 100675975);
			NetworkSingleton<T>.NativeMethodInfoPtr_set_Instance_Protected_Static_set_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSingleton<T>>.NativeClassPtr, 100675976);
			NetworkSingleton<T>.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSingleton<T>>.NativeClassPtr, 100675977);
			NetworkSingleton<T>.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSingleton<T>>.NativeClassPtr, 100675978);
			NetworkSingleton<T>.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSingleton<T>>.NativeClassPtr, 100675979);
			NetworkSingleton<T>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSingleton<T>>.NativeClassPtr, 100675980);
			NetworkSingleton<T>.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSingleton<T>>.NativeClassPtr, 100675981);
			NetworkSingleton<T>.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSingleton<T>>.NativeClassPtr, 100675982);
			NetworkSingleton<T>.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSingleton<T>>.NativeClassPtr, 100675983);
			NetworkSingleton<T>.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkSingleton<T>>.NativeClassPtr, 100675984);
		}

		// Token: 0x17001D91 RID: 7569
		// (get) Token: 0x060062F0 RID: 25328 RVA: 0x001C591C File Offset: 0x001C3B1C
		public unsafe static bool InstanceExists
		{
			[CallerCount(63)]
			[CachedScanResults(RefRangeStart = 204332, RefRangeEnd = 204395, XrefRangeStart = 204326, XrefRangeEnd = 204332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NetworkSingleton<T>.NativeMethodInfoPtr_get_InstanceExists_Public_Static_get_Boolean_0, 0, (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17001D92 RID: 7570
		// (get) Token: 0x060062F1 RID: 25329 RVA: 0x001C594C File Offset: 0x001C3B4C
		// (set) Token: 0x060062F2 RID: 25330 RVA: 0x001C597C File Offset: 0x001C3B7C
		public unsafe static T Instance
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204395, XrefRangeEnd = 204396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(NetworkSingleton<T>.NativeMethodInfoPtr_get_Instance_Public_Static_get_T_0, 0, (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.PointerToValueGeneric<T>(objectPointer, false, true);
			}
			[CallerCount(238)]
			[CachedScanResults(RefRangeStart = 204410, RefRangeEnd = 204648, XrefRangeStart = 204396, XrefRangeEnd = 204410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				ref System.IntPtr ptr2 = ref *ptr;
				System.IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = value;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref value;
				}
				ptr2 = intPtr;
				System.IntPtr returnedException;
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NetworkSingleton<T>.NativeMethodInfoPtr_set_Instance_Protected_Static_set_Void_T_0, 0, (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x060062F3 RID: 25331 RVA: 0x001C59E8 File Offset: 0x001C3BE8
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NetworkSingleton<T>.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060062F4 RID: 25332 RVA: 0x001C5A24 File Offset: 0x001C3C24
		[CallerCount(31)]
		[CachedScanResults(RefRangeStart = 204649, RefRangeEnd = 204680, XrefRangeStart = 204648, XrefRangeEnd = 204649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NetworkSingleton<T>.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060062F5 RID: 25333 RVA: 0x001C5A60 File Offset: 0x001C3C60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 204686, RefRangeEnd = 204687, XrefRangeStart = 204680, XrefRangeEnd = 204686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NetworkSingleton<T>.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060062F6 RID: 25334 RVA: 0x001C5A9C File Offset: 0x001C3C9C
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 140600, RefRangeEnd = 140622, XrefRangeStart = 140600, XrefRangeEnd = 140622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NetworkSingleton() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NetworkSingleton<T>>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkSingleton<T>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060062F7 RID: 25335 RVA: 0x001C5AD8 File Offset: 0x001C3CD8
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 204687, RefRangeEnd = 204708, XrefRangeStart = 204687, XrefRangeEnd = 204687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NetworkSingleton<T>.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060062F8 RID: 25336 RVA: 0x001C5B14 File Offset: 0x001C3D14
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 204708, RefRangeEnd = 204729, XrefRangeStart = 204708, XrefRangeEnd = 204708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NetworkSingleton<T>.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060062F9 RID: 25337 RVA: 0x001C5B50 File Offset: 0x001C3D50
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NetworkSingleton<T>.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060062FA RID: 25338 RVA: 0x001C5B8C File Offset: 0x001C3D8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 204755, RefRangeEnd = 204756, XrefRangeStart = 204729, XrefRangeEnd = 204755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Protected_Virtual_New_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NetworkSingleton<T>.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060062FB RID: 25339 RVA: 0x0002E84B File Offset: 0x0002CA4B
		public NetworkSingleton(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001D8D RID: 7565
		// (get) Token: 0x060062FC RID: 25340 RVA: 0x001C5BC8 File Offset: 0x001C3DC8
		// (set) Token: 0x060062FD RID: 25341 RVA: 0x001C5BEC File Offset: 0x001C3DEC
		public unsafe static T instance
		{
			get
			{
				System.IntPtr objectPointer;
				IL2CPP.il2cpp_field_static_get_value(NetworkSingleton<T>.NativeFieldInfoPtr_instance, (void*)(&objectPointer));
				return IL2CPP.PointerToValueGeneric<T>(objectPointer, false, false);
			}
			set
			{
				System.IntPtr nativeFieldInfoPtr_instance = NetworkSingleton<T>.NativeFieldInfoPtr_instance;
				T value2;
				if (!typeof(T).IsValueType)
				{
					T t = value;
					if (!(t is string))
					{
						ref T ptr = value2 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase);
						if (ref ptr != null)
						{
							value2 = ref ptr;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr)))
							{
								value2 = IL2CPP.il2cpp_object_unbox(ref ptr);
							}
						}
					}
					else
					{
						value2 = IL2CPP.ManagedStringToIl2Cpp(t as string);
					}
				}
				else
				{
					value2 = ref value;
				}
				IL2CPP.il2cpp_field_static_set_value(nativeFieldInfoPtr_instance, (void*)(&value2));
			}
		}

		// Token: 0x17001D8E RID: 7566
		// (get) Token: 0x060062FE RID: 25342 RVA: 0x001C5C54 File Offset: 0x001C3E54
		// (set) Token: 0x060062FF RID: 25343 RVA: 0x0002E854 File Offset: 0x0002CA54
		public unsafe bool Destroyed
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkSingleton<T>.NativeFieldInfoPtr_Destroyed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkSingleton<T>.NativeFieldInfoPtr_Destroyed)) = value;
			}
		}

		// Token: 0x17001D8F RID: 7567
		// (get) Token: 0x06006300 RID: 25344 RVA: 0x001C5C7C File Offset: 0x001C3E7C
		// (set) Token: 0x06006301 RID: 25345 RVA: 0x0002E86F File Offset: 0x0002CA6F
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkSingleton<T>.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkSingleton<T>.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001D90 RID: 7568
		// (get) Token: 0x06006302 RID: 25346 RVA: 0x001C5CA4 File Offset: 0x001C3EA4
		// (set) Token: 0x06006303 RID: 25347 RVA: 0x0002E88A File Offset: 0x0002CA8A
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkSingleton<T>.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkSingleton<T>.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04004388 RID: 17288
		private static readonly System.IntPtr NativeFieldInfoPtr_instance;

		// Token: 0x04004389 RID: 17289
		private static readonly System.IntPtr NativeFieldInfoPtr_Destroyed;

		// Token: 0x0400438A RID: 17290
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x0400438B RID: 17291
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x0400438C RID: 17292
		private static readonly System.IntPtr NativeMethodInfoPtr_get_InstanceExists_Public_Static_get_Boolean_0;

		// Token: 0x0400438D RID: 17293
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_T_0;

		// Token: 0x0400438E RID: 17294
		private static readonly System.IntPtr NativeMethodInfoPtr_set_Instance_Protected_Static_set_Void_T_0;

		// Token: 0x0400438F RID: 17295
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_1;

		// Token: 0x04004390 RID: 17296
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04004391 RID: 17297
		private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_1;

		// Token: 0x04004392 RID: 17298
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04004393 RID: 17299
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04004394 RID: 17300
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04004395 RID: 17301
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04004396 RID: 17302
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0;
	}
}
